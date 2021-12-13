using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using GeoCoordinatePortable;
using NWS.WebClient;
using NWS.Model;
using System.Threading.Tasks;

namespace NWS.WeatherDataService
{
    /// <summary>
    /// Gets weather data from the National Weather Service (api.weather.gov)
    /// </summary>
    public class WeatherDataService : IWeatherDataProvider
    {
        readonly IWebClient webClient;

        public WeatherDataService()
        {
            webClient = new NWS.WebClient.Default.WebClient();
        }

        public WeatherDataService(IWebClient webClient)
        {
            this.webClient = webClient;
        }

        /// <summary>
        /// Gets the current weather conditions for a given latitude and longitude
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lng">Longitude</param>
        /// <returns>A CurrentConditionsResponse containing current weather data conditions.</returns>
        public async Task<CurrentConditionsResponse> GetCurrentConditionsAsync(decimal lat, decimal lng)
        {
            CurrentConditionsResponse response = null;
            
            //Get the current list of stations for the given latitude and longitude.
            var redirectResponseText = await webClient.GetAsync($"https://api.weather.gov/points/{ lat.ToString("0.####") },{ lng.ToString("0.####") }");

            //Parse the json response
            dynamic json = JObject.Parse(redirectResponseText);

            //Get the URL of the observation stations from the response
            var observationStationsUrl = (string)json.properties.observationStations;

            //Load the observation stations URL from the API
            var observationResponseText = await webClient.GetAsync(observationStationsUrl);

            //Parse the json response
            dynamic json2 = JObject.Parse(observationResponseText);

            //The station list is a property in the response called "features"
            var stations = json2.features;

            //Ensure we have a list of stations
            if (stations != null && stations.Count > 0)
            {
                //Loop over the list of stations
                for (int i = 0; i < stations.Count; i++)
                {
                    var s = stations[i];

                    if (s != null)
                    {
                        //We have a station. Instantiate a WeatherStation object and fill some properties.
                        var station = new WeatherStation()
                        {
                            Name = s.properties.name,
                            StationIdentifier = s.properties.stationIdentifier,
                            ElevationInMeters = 0,
                            Latitude = 0,
                            Longitude = 0
                        };

                        if (s.properties.elevation.value != null)
                        {
                            station.ElevationInMeters = s.properties.elevation.value;
                        }

                        if (s.geometry.coordinates[0] != null)
                        {
                            station.Longitude = s.geometry.coordinates[0];
                        }

                        if (s.geometry.coordinates[1] != null)
                        {
                            station.Latitude = s.geometry.coordinates[1];
                        }

                        //Attempt to get the current conditions for the station provided.
                        response = await GetCurrentConditionsForStationAsync(station);
                    }

                    //If we have current conditions, return it. Otherwise, continue through loop.
                    if (response != null)
                    {
                        break;
                    }
                }
            }

            return response;
        }

        /// <summary>
        /// Gets the weather forecast for a given latitude and longitude
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lng">Longitude</param>
        /// <returns>A ForecastResponse containing forecast data for the given latitude and longitude</returns>
        public async Task<ForecastResponse> GetForecastAsync(decimal lat, decimal lng)
        {
            //Get the gridpoint information for the given latitude and longitude.
            var redirectResponseText = await webClient.GetAsync($"https://api.weather.gov/points/{ lat.ToString("0.####") },{ lng.ToString("0.####") }");

            //Parse the json response
            dynamic json = JObject.Parse(redirectResponseText);

            //Get the forecast Url from the response
            var forecastUrl = (string)json.properties.forecast;

            //Load the forecast Url
            var forecastResponseText = await webClient.GetAsync(forecastUrl);

            //Parse the json response
            dynamic json2 = JObject.Parse(forecastResponseText);

            //Instantiate a new ForecastResponse object and fill it with the data received
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

        /// <summary>
        /// Retrieves the closest weather station for the given latitude and longitude coordinates
        /// </summary>
        /// <param name="lat">Latitude to search</param>
        /// <param name="lng">Longitude to search</param>
        /// <param name="state">The United States state to search in</param>
        /// <param name="notStationIdentifierList">Optional parameter can be used to exclude stations from being returned</param>
        /// <returns>The closest weather station.</returns>
        public async Task<WeatherStation> GetClosestWeatherStationAsync(decimal lat, decimal lng, StateTypes state, List<string> notStationIdentifierList = null)
        {
            //Get all weather stations for the given state
            var stations = await GetAllWeatherStationsForStateAsync(state);

            //Specifically exclude any weather stations that shouldn't be included
            if (notStationIdentifierList != null && notStationIdentifierList.Count > 0)
            {
                stations = stations.Where(s => !notStationIdentifierList.Any(s2 => s2 == s.StationIdentifier)).ToList();
            }

            WeatherStation closestStation = null;
            double? closestStationDistance = null;

            //Loop through the stations until we find the closest one.
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

        //Used to thread lock a memory cache resource in GetAllWeatherStationsAsync
        static object stationListLock = new object();

        /// <summary>
        /// Gets all weather stations for a given state from the API
        /// </summary>
        /// <param name="state">The state to get the Weather Stations for</param>
        /// <returns>A list of weather stations for the given state</returns>
        public async Task<List<WeatherStation>> GetAllWeatherStationsForStateAsync(StateTypes state)
        {
            var list = new List<WeatherStation>();

            //Load the list of weather stations from the API
            var stateList = await webClient.GetAsync($"https://api.weather.gov/stations?state={state}");

            //Parse the resulting json
            dynamic json = JObject.Parse(stateList);

            //Convert each returned weather station to a WeatherStation object and add it to the list to return
            foreach (var s in json.features)
            {
                var station = new WeatherStation()
                {
                    StationIdentifier = s.properties.stationIdentifier,
                    Name = s.properties.name,
                    ElevationInMeters = s.properties.elevation.value
                };

                if (s.properties.elevation.value != null)
                {
                    station.ElevationInMeters = s.properties.elevation.value;
                }

                if (s.geometry.coordinates[0] != null)
                {
                    station.Longitude = s.geometry.coordinates[0];
                }

                if (s.geometry.coordinates[1] != null)
                {
                    station.Latitude = s.geometry.coordinates[1];
                }

                list.Add(s);
            }

            //Return list from short term memory cache
            return list;
        }

        async Task<CurrentConditionsResponse> GetCurrentConditionsForStationAsync(WeatherStation station)
        {
            if (station != null)
            {
                //Get the current observations for the provided weather station
                var observationsText = await webClient.GetAsync($"https://api.weather.gov/stations/{ station.StationIdentifier }/observations/latest");

                //Parse the json response
                dynamic json = JObject.Parse(observationsText);

                //Get the list of properties which contain the current condition values
                dynamic properties = json.properties;

                //Instantiate a CurrentConditionsResponse and fill with the properties
                var response = new CurrentConditionsResponse
                {
                    WeatherStation = station,
                    TextDescription = properties.textDescription,
                    ObservationDate = properties.timestamp,
                    TemperatureCelsius = TryConvertToDecimal(properties.temperature.value),
                    DewPointCelsius = TryConvertToDecimal(properties.dewpoint.value),
                    WindDirection = TryConvertToDecimal(properties.windDirection.value),
                    WindSpeedKilometersPerHour = TryConvertToDecimal(properties.windSpeed.value),
                    WindGustKilometersPerHour = TryConvertToDecimal(properties.windGust.value),
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
                    response.TemperatureFahrenheit = Utilities.ConvertCelsiusToFahrenheit(response.TemperatureCelsius.Value);
                }

                if (response.DewPointCelsius.HasValue)
                {
                    response.DewPointFahrenheit = Utilities.ConvertCelsiusToFahrenheit(response.DewPointCelsius.Value);
                }

                if (response.WindChillCelsius.HasValue)
                {
                    response.WindChillFahrenheit = Utilities.ConvertCelsiusToFahrenheit(response.WindChillCelsius.Value);
                }

                if (response.HeatIndexCelsius.HasValue)
                {
                    response.HeatIndexFahrenheit = Utilities.ConvertCelsiusToFahrenheit(response.HeatIndexCelsius.Value);
                }

                if (response.WindSpeedKilometersPerHour.HasValue)
                {
                    response.WindSpeedMilesPerHour = Utilities.ConvertKilometersPerHourToMilesPerHour(response.WindSpeedKilometersPerHour.Value);
                }

                if (response.WindGustKilometersPerHour.HasValue)
                {
                    response.WindGustMilesPerHour = Utilities.ConvertKilometersPerHourToMilesPerHour(response.WindGustKilometersPerHour.Value);
                }

                response.RawData = observationsText;

                response.Station = station;

                return response;
            }

            return null;
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
