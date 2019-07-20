using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Caching;
using System.Linq;
using Newtonsoft.Json.Linq;
using GeoCoordinatePortable;
using NWS.WebClient;
using NWS.Model;

namespace NWS.WeatherDataService
{
    public class WeatherDataService : IWeatherDataProvider
    {
        IWebClient webClient;

        static object stationListLock = new object();

        public WeatherDataService()
        {
            webClient = new NWS.WebClient.Default.WebClient();
        }

        public WeatherDataService(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        public CurrentConditionsResponse GetCurrentConditions(decimal lat, decimal lng)
        {
            var notStationIdList = new List<string>();

            var count = 0;

            CurrentConditionsResponse response = null;

            while (count < 5 && (response == null || !response.TemperatureCelsius.HasValue))
            {
                var station = GetClosestWeatherStation(lat, lng, notStationIdList);

                response = GetCurrentConditionsForStation(station);

                if (response == null || !response.TemperatureCelsius.HasValue)
                {
                    notStationIdList.Add(station.StationIdentifier);
                }

                count++;
            }

            return response;
        }

        public ForecastResponse GetForecast(decimal lat, decimal lng)
        {
            var binaryResponse = webClient.Get(string.Format("https://api.weather.gov/points/{0},{1}", lat.ToString("0.####"), lng.ToString("0.####")));

            var redirectResponseText = Encoding.Default.GetString(binaryResponse);

            //We just need the "detail" attribute to know what gridpoints are there.

            dynamic json = JObject.Parse(redirectResponseText);

            var forecastUrl = (string)json.properties.forecast;

            binaryResponse = webClient.Get(forecastUrl);

            var forecastResponseText = Encoding.Default.GetString(binaryResponse);

            dynamic json2 = JObject.Parse(forecastResponseText);

            var response = new ForecastResponse()
            {
                Periods = new List<ForecastPeriod>(),
                ElevationInMeters = json2.properties.elevation.value,
                LastUpdatedDate = json2.properties.updated,
                Latitude = lat,
                Longitude = lng
            };

            foreach (dynamic p in json2.properties.periods)
            {
                response.Periods.Add(new ForecastPeriod()
                {
                    Name = p.name,
                    StartTime = p.startTime,
                    EndTime = p.endTime,
                    IsDayTime = p.isDaytime,
                    TemperatureInFahrenheit = p.temperature,
                    WindSpeed = p.windSpeed,
                    WindDirection = p.windDirection,
                    ForecastShort = p.shortForecast,
                    ForecastLong = p.detailedForecast
                });
            }

            response.RawData = forecastResponseText;

            return response;
        }

        CurrentConditionsResponse GetCurrentConditionsForStation(WeatherStation station)
        {
            if (station != null)
            {
                var binaryResponse = webClient.Get(string.Format("https://api.weather.gov/stations/{0}/observations/latest", station.StationIdentifier));

                var observationsText = Encoding.Default.GetString(binaryResponse);

                dynamic json = JObject.Parse(observationsText);

                dynamic properties = json.properties;

                var response = new CurrentConditionsResponse
                {
                    WeatherStation = station,
                    TextDescription = properties.textDescription,
                    ObservationDate = properties.timestamp,
                    TemperatureCelsius = TryConvertToDecimal(properties.temperature.value),
                    DewPointCelsius = TryConvertToDecimal(properties.dewpoint.value),
                    WindDirection = TryConvertToDecimal(properties.windDirection.value),
                    WindSpeedMetersPerSecond = TryConvertToDecimal(properties.windSpeed.value),
                    WindGustMetersPerSecond = TryConvertToDecimal(properties.windGust.value),
                    BarometricPressure = TryConvertToDecimal(properties.barometricPressure.value),
                    SeaLevelPressure = TryConvertToDecimal(properties.seaLevelPressure.value),
                    VisibilityMeters = TryConvertToDecimal(properties.visibility.value),
                    RelativeHumidityPercent = TryConvertToDecimal(properties.relativeHumidity.value),
                    WindChillCelsius = TryConvertToDecimal(properties.windChill.value),
                    HeatIndexCelsius = TryConvertToDecimal(properties.heatIndex.value)
                };

                //Convert celsius to fahrenheit

                if (response.TemperatureCelsius.HasValue)
                {
                    response.TemperatureFahrenheit = ConvertCelsiusToFahrenheit(response.TemperatureCelsius.Value);
                }

                if (response.DewPointCelsius.HasValue)
                {
                    response.DewPointFahrenheit = ConvertCelsiusToFahrenheit(response.DewPointCelsius.Value);
                }

                if (response.WindChillCelsius.HasValue)
                {
                    response.WindChillFahrenheit = ConvertCelsiusToFahrenheit(response.WindChillCelsius.Value);
                }

                if (response.HeatIndexCelsius.HasValue)
                {
                    response.HeatIndexFahrenheit = ConvertCelsiusToFahrenheit(response.HeatIndexCelsius.Value);
                }

                if (response.WindSpeedMetersPerSecond.HasValue)
                {
                    response.WindSpeedMilesPerHour = ConvertMetersPerSecondToMilesPerHour(response.WindSpeedMetersPerSecond.Value);
                }

                if (response.WindGustMetersPerSecond.HasValue)
                {
                    response.WindGustMilesPerHour = ConvertMetersPerSecondToMilesPerHour(response.WindGustMetersPerSecond.Value);
                }

                response.RawData = observationsText;

                return response;
            }

            return null;
        }

        internal WeatherStation GetClosestWeatherStation(decimal lat, decimal lng, List<string> notStationIdentifierList = null)
        {
            var stations = GetAllWeatherStations();

            if (notStationIdentifierList != null && notStationIdentifierList.Count > 0)
            {
                stations = stations.Where(s => !notStationIdentifierList.Any(s2 => s2 == s.StationIdentifier)).ToList();
            }

            WeatherStation closestStation = null;
            double? closestStationDistance = null;

            foreach (var s in stations)
            {
                var sCoord = new GeoCoordinate(Convert.ToDouble(s.Latitude), Convert.ToDouble(s.Longitude));
                var eCoord = new GeoCoordinate(Convert.ToDouble(lat), Convert.ToDouble(lng));

                var distance = sCoord.GetDistanceTo(eCoord);

                if (!closestStationDistance.HasValue || closestStationDistance.Value > distance)
                {
                    closestStationDistance = distance;
                    closestStation = s;
                }
            }

            return closestStation;
        }

        internal List<WeatherStation> GetAllWeatherStations()
        {
            var shortKey = "allweatherstations-short";
            var longKey = "allweatherstations-long";

            var memoryCache = MemoryCache.Default;

            if (!memoryCache.Contains(shortKey))
            {
                //Multi thread safe.
                lock (stationListLock)
                {
                    //Make sure the memcache still doesn't contain what we need after lock is obtained.
                    if (!memoryCache.Contains(shortKey))
                    {
                        var list = new List<WeatherStation>();

                        try
                        {
                            var binaryResponse = webClient.Get("https://api.weather.gov/stations");

                            dynamic json = JObject.Parse(Encoding.Default.GetString(binaryResponse));

                            foreach (var station in json.features)
                            {
                                list.Add(new WeatherStation()
                                {
                                    Latitude = station.geometry.coordinates[1],
                                    Longitude = station.geometry.coordinates[0],
                                    StationIdentifier = station.properties.stationIdentifier,
                                    Name = station.properties.name
                                });
                            }

                            memoryCache.Add(shortKey, list, DateTimeOffset.UtcNow.AddHours(48));

                            //Create longer cache in case of future failures (though this instance isn't likely to live that long anyway).
                            memoryCache.Add(longKey, list, DateTimeOffset.UtcNow.AddHours(120));
                        }
                        catch (Exception)
                        {
                            if (memoryCache.Contains(longKey))
                            {
                                //We can load from longterm cache.

                                list = (List<WeatherStation>)memoryCache.Get(longKey);

                                memoryCache.Add(shortKey, list, DateTimeOffset.UtcNow.AddHours(48));
                            }
                            else
                            {
                                //No cached version was available and something happened while trying to get the latest list.
                                //Return empty list.  Future TODO: Longterm storage of list somewhere that we can retreive in this case.
                                return list;
                            }
                        }
                    }
                }
            }

            return (List<WeatherStation>)memoryCache.Get(shortKey);
        }

        public decimal ConvertCelsiusToFahrenheit(decimal celsius)
        {
            return (celsius * (9 / 5)) + 32;
        }

        public decimal ConvertMetersPerSecondToMilesPerHour(decimal speed)
        {
            return speed * 2.23694m;
        }

        decimal? TryConvertToDecimal(dynamic value)
        {
            //Dynamic values are difficult to convert to the correct format... especially if they can contain "null" for a value.

            decimal? result = null;

            decimal test = 0;

            if (decimal.TryParse(value.ToString(), out test))
            {
                result = test;
            }

            return result;
        }
    }
}
