using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Text;
using NWS.WebClient;

namespace NWS.WeatherDataService.Tests.WebClients
{
    class CurrentConditionsValidWebClient : IWebClient
    {
        public byte[] Get(string url)
        {
            if (url.Equals("https://api.weather.gov/stations"))
            {
                return Encoding.UTF8.GetBytes(AllStations);
            }

            return new byte[0];   
        }

        public async Task<byte[]> GetAsync(string url)
        {
            return await Task.Run(() => {

                var response = string.Empty;

                if (url.StartsWith("https://api.weather.gov/stations/") && url.Contains("/observations/latest"))
                {
                    response = LatestObservations;
                }
                else if (url.StartsWith("https://api.weather.gov/points/"))
                {
                    response = LatLngToPointRedirect;
                }
                else if (url.Equals("https://api.weather.gov/gridpoints/SLC/105,209/forecast"))
                {
                    response = GridPointForecast;
                }

                return Encoding.UTF8.GetBytes(response);
            });
        }

        public byte[] Post(string url, NameValueCollection postData)
        {
            throw new System.NotImplementedException();
        }

        string GridPointForecast
        {
            get
            {
                return @"{
                    ""@context"": [
                        ""https://raw.githubusercontent.com/geojson/geojson-ld/master/contexts/geojson-base.jsonld"",
                        {
                            ""wx"": ""https://api.weather.gov/ontology#"",
                            ""geo"": ""http://www.opengis.net/ont/geosparql#"",
                            ""unit"": ""http://codes.wmo.int/common/unit/"",
                            ""@vocab"": ""https://api.weather.gov/ontology#""
                        }
                    ],
                    ""type"": ""Feature"",
                    ""geometry"": {
                        ""type"": ""GeometryCollection"",
                        ""geometries"": [
                            {
                                ""type"": ""Point"",
                                ""coordinates"": [
                                    -111.7956282,
                                    41.533301700000003
                                ]
                            },
                            {
                                ""type"": ""Polygon"",
                                ""coordinates"": [
                                    [
                                        [
                                            -111.8118944,
                                            41.542794600000001
                                        ],
                                        [
                                            -111.8082843,
                                            41.521110999999998
                                        ],
                                        [
                                            -111.77936509999999,
                                            41.523806799999996
                                        ],
                                        [
                                            -111.78296909999999,
                                            41.545490599999994
                                        ],
                                        [
                                            -111.8118944,
                                            41.542794600000001
                                        ]
                                    ]
                                ]
                            }
                        ]
                    },
                    ""properties"": {
                        ""updated"": ""2019-02-20T20:10:37+00:00"",
                        ""units"": ""us"",
                        ""forecastGenerator"": ""BaselineForecastGenerator"",
                        ""generatedAt"": ""2019-02-20T20:20:41+00:00"",
                        ""updateTime"": ""2019-02-20T20:10:37+00:00"",
                        ""validTimes"": ""2019-02-20T14:00:00+00:00/P7DT11H"",
                        ""elevation"": {
                            ""value"": 1524,
                            ""unitCode"": ""unit:m""
                        },
                        ""periods"": [
                            {
                                ""number"": 1,
                                ""name"": ""This Afternoon"",
                                ""startTime"": ""2019-02-20T13:00:00-07:00"",
                                ""endTime"": ""2019-02-20T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 28,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": ""falling"",
                                ""windSpeed"": ""3 to 12 mph"",
                                ""windDirection"": ""S"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/snow,100?size=medium"",
                                ""shortForecast"": ""Light Snow"",
                                ""detailedForecast"": ""Snow. Mostly cloudy. High near 28, with temperatures falling to around 26 in the afternoon. South wind 3 to 12 mph. Chance of precipitation is 100%. New snow accumulation of less than one inch possible.""
                            },
                            {
                                ""number"": 2,
                                ""name"": ""Tonight"",
                                ""startTime"": ""2019-02-20T18:00:00-07:00"",
                                ""endTime"": ""2019-02-21T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 11,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""3 to 14 mph"",
                                ""windDirection"": ""SE"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/snow,30?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow. Mostly cloudy, with a low around 11. Wind chill values as low as -3. Southeast wind 3 to 14 mph. Chance of precipitation is 30%. New snow accumulation of less than one inch possible.""
                            },
                            {
                                ""number"": 3,
                                ""name"": ""Thursday"",
                                ""startTime"": ""2019-02-21T06:00:00-07:00"",
                                ""endTime"": ""2019-02-21T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 30,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": ""falling"",
                                ""windSpeed"": ""12 to 16 mph"",
                                ""windDirection"": ""ENE"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/snow,30?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow. Mostly cloudy. High near 30, with temperatures falling to around 27 in the afternoon. Wind chill values as low as -5. East northeast wind 12 to 16 mph. Chance of precipitation is 30%. New snow accumulation of less than one inch possible.""
                            },
                            {
                                ""number"": 4,
                                ""name"": ""Thursday Night"",
                                ""startTime"": ""2019-02-21T18:00:00-07:00"",
                                ""endTime"": ""2019-02-22T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 10,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""9 to 13 mph"",
                                ""windDirection"": ""ENE"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/snow,30/snow,20?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow before 5am. Mostly cloudy, with a low around 10. Wind chill values as low as -1. East northeast wind 9 to 13 mph. Chance of precipitation is 30%. New snow accumulation of less than half an inch possible.""
                            },
                            {
                                ""number"": 5,
                                ""name"": ""Friday"",
                                ""startTime"": ""2019-02-22T06:00:00-07:00"",
                                ""endTime"": ""2019-02-22T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 29,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""5 to 9 mph"",
                                ""windDirection"": ""NNW"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/sct?size=medium"",
                                ""shortForecast"": ""Mostly Sunny"",
                                ""detailedForecast"": ""Mostly sunny, with a high near 29. North northwest wind 5 to 9 mph.""
                            },
                            {
                                ""number"": 6,
                                ""name"": ""Friday Night"",
                                ""startTime"": ""2019-02-22T18:00:00-07:00"",
                                ""endTime"": ""2019-02-23T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 10,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""6 mph"",
                                ""windDirection"": ""SSW"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/sct/snow,20?size=medium"",
                                ""shortForecast"": ""Partly Cloudy then Slight Chance Light Snow"",
                                ""detailedForecast"": ""A slight chance of snow after 5am. Partly cloudy, with a low around 10. Chance of precipitation is 20%. New snow accumulation of less than half an inch possible.""
                            },
                            {
                                ""number"": 7,
                                ""name"": ""Saturday"",
                                ""startTime"": ""2019-02-23T06:00:00-07:00"",
                                ""endTime"": ""2019-02-23T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 30,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""8 mph"",
                                ""windDirection"": ""SSW"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/snow,20/snow,40?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow. Mostly cloudy, with a high near 30. Chance of precipitation is 40%. New snow accumulation of less than half an inch possible.""
                            },
                            {
                                ""number"": 8,
                                ""name"": ""Saturday Night"",
                                ""startTime"": ""2019-02-23T18:00:00-07:00"",
                                ""endTime"": ""2019-02-24T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 19,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""7 mph"",
                                ""windDirection"": ""SSW"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/snow?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow. Mostly cloudy, with a low around 19.""
                            },
                            {
                                ""number"": 9,
                                ""name"": ""Sunday"",
                                ""startTime"": ""2019-02-24T06:00:00-07:00"",
                                ""endTime"": ""2019-02-24T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 36,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""7 mph"",
                                ""windDirection"": ""SSW"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/snow?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow. Cloudy, with a high near 36.""
                            },
                            {
                                ""number"": 10,
                                ""name"": ""Sunday Night"",
                                ""startTime"": ""2019-02-24T18:00:00-07:00"",
                                ""endTime"": ""2019-02-25T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 24,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""8 mph"",
                                ""windDirection"": ""S"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/snow?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow. Cloudy, with a low around 24.""
                            },
                            {
                                ""number"": 11,
                                ""name"": ""Monday"",
                                ""startTime"": ""2019-02-25T06:00:00-07:00"",
                                ""endTime"": ""2019-02-25T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 36,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""10 mph"",
                                ""windDirection"": ""SW"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/snow?size=medium"",
                                ""shortForecast"": ""Chance Light Snow"",
                                ""detailedForecast"": ""A chance of snow before 5pm, then a chance of snow showers. Mostly cloudy, with a high near 36.""
                            },
                            {
                                ""number"": 12,
                                ""name"": ""Monday Night"",
                                ""startTime"": ""2019-02-25T18:00:00-07:00"",
                                ""endTime"": ""2019-02-26T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 20,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""5 to 8 mph"",
                                ""windDirection"": ""SSW"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/snow?size=medium"",
                                ""shortForecast"": ""Chance Snow Showers"",
                                ""detailedForecast"": ""A chance of snow showers. Mostly cloudy, with a low around 20.""
                            },
                            {
                                ""number"": 13,
                                ""name"": ""Tuesday"",
                                ""startTime"": ""2019-02-26T06:00:00-07:00"",
                                ""endTime"": ""2019-02-26T18:00:00-07:00"",
                                ""isDaytime"": true,
                                ""temperature"": 38,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""7 mph"",
                                ""windDirection"": ""S"",
                                ""icon"": ""https://api.weather.gov/icons/land/day/snow?size=medium"",
                                ""shortForecast"": ""Chance Snow Showers"",
                                ""detailedForecast"": ""A chance of snow showers. Mostly cloudy, with a high near 38.""
                            },
                            {
                                ""number"": 14,
                                ""name"": ""Tuesday Night"",
                                ""startTime"": ""2019-02-26T18:00:00-07:00"",
                                ""endTime"": ""2019-02-27T06:00:00-07:00"",
                                ""isDaytime"": false,
                                ""temperature"": 28,
                                ""temperatureUnit"": ""F"",
                                ""temperatureTrend"": null,
                                ""windSpeed"": ""7 mph"",
                                ""windDirection"": ""S"",
                                ""icon"": ""https://api.weather.gov/icons/land/night/snow?size=medium"",
                                ""shortForecast"": ""Chance Snow Showers"",
                                ""detailedForecast"": ""A chance of snow showers. Mostly cloudy, with a low around 28.""
                            }
                        ]
                    }
                }";
            }
        }

        string LatLngToPointRedirect
        {
            get
            {
                return @"{
                    ""correlationId"": ""39de95cc-60f0-4d4d-8e65-6e92bc216e09"",
                    ""title"": ""Redirect"",
                    ""type"": ""https://api.weather.gov/problems/GridpointRedirect"",
                    ""status"": 301,
                    ""detail"": ""The requested data can be found here: /gridpoints/SLC/105,209/forecast"",
                    ""instance"": ""https://api.weather.gov/requests/39de95cc-60f0-4d4d-8e65-6e92bc216e09""
                }";
            }
        }

        string LatestObservations
        {
            get
            {
                return @"{
                    ""@context"": [
                        ""https://raw.githubusercontent.com/geojson/geojson-ld/master/contexts/geojson-base.jsonld"",
                        {
                            ""wx"": ""https://api.weather.gov/ontology#"",
                            ""s"": ""https://schema.org/"",
                            ""geo"": ""http://www.opengis.net/ont/geosparql#"",
                            ""unit"": ""http://codes.wmo.int/common/unit/"",
                            ""@vocab"": ""https://api.weather.gov/ontology#"",
                            ""geometry"": {
                                ""@id"": ""s:GeoCoordinates"",
                                ""@type"": ""geo:wktLiteral""
                            },
                            ""city"": ""s:addressLocality"",
                            ""state"": ""s:addressRegion"",
                            ""distance"": {
                                ""@id"": ""s:Distance"",
                                ""@type"": ""s:QuantitativeValue""
                            },
                            ""bearing"": {
                                ""@type"": ""s:QuantitativeValue""
                            },
                            ""value"": {
                                ""@id"": ""s:value""
                            },
                            ""unitCode"": {
                                ""@id"": ""s:unitCode"",
                                ""@type"": ""@id""
                            },
                            ""forecastOffice"": {
                                ""@type"": ""@id""
                            },
                            ""forecastGridData"": {
                                ""@type"": ""@id""
                            },
                            ""publicZone"": {
                                ""@type"": ""@id""
                            },
                            ""county"": {
                                ""@type"": ""@id""
                            }
                        }
                    ],
                    ""id"": ""https://api.weather.gov/stations/KLGU/observations/2019-02-20T16:51:00+00:00"",
                    ""type"": ""Feature"",
                    ""geometry"": {
                        ""type"": ""Point"",
                        ""coordinates"": [
                            -111.84999999999999,
                            41.780000000000001
                        ]
                    },
                    ""properties"": {
                        ""@id"": ""https://api.weather.gov/stations/KLGU/observations/2019-02-20T16:51:00+00:00"",
                        ""@type"": ""wx:ObservationStation"",
                        ""elevation"": {
                            ""value"": 1358,
                            ""unitCode"": ""unit:m""
                        },
                        ""station"": ""https://api.weather.gov/stations/KLGU"",
                        ""timestamp"": ""2019-02-20T16:51:00+00:00"",
                        ""rawMessage"": ""KLGU 201651Z AUTO 18012KT 10SM FEW047 M04/M11 A2969 RMK AO2 SLP088 T10441106"",
                        ""textDescription"": ""Mostly Clear"",
                        ""icon"": ""https://api.weather.gov/icons/land/day/few?size=medium"",
                        ""presentWeather"": [],
                        ""temperature"": {
                            ""value"": -4.3999999999999773,
                            ""unitCode"": ""unit:degC"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""dewpoint"": {
                            ""value"": -10.599999999999966,
                            ""unitCode"": ""unit:degC"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""windDirection"": {
                            ""value"": 180,
                            ""unitCode"": ""unit:degree_(angle)"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""windSpeed"": {
                            ""value"": 6.2000000000000002,
                            ""unitCode"": ""unit:m_s-1"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""windGust"": {
                            ""value"": null,
                            ""unitCode"": ""unit:m_s-1"",
                            ""qualityControl"": ""qc:Z""
                        },
                        ""barometricPressure"": {
                            ""value"": 100540,
                            ""unitCode"": ""unit:Pa"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""seaLevelPressure"": {
                            ""value"": 100880,
                            ""unitCode"": ""unit:Pa"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""visibility"": {
                            ""value"": 16090,
                            ""unitCode"": ""unit:m"",
                            ""qualityControl"": ""qc:C""
                        },
                        ""maxTemperatureLast24Hours"": {
                            ""value"": null,
                            ""unitCode"": ""unit:degC"",
                            ""qualityControl"": null
                        },
                        ""minTemperatureLast24Hours"": {
                            ""value"": null,
                            ""unitCode"": ""unit:degC"",
                            ""qualityControl"": null
                        },
                        ""precipitationLastHour"": {
                            ""value"": null,
                            ""unitCode"": ""unit:m"",
                            ""qualityControl"": ""qc:Z""
                        },
                        ""precipitationLast3Hours"": {
                            ""value"": null,
                            ""unitCode"": ""unit:m"",
                            ""qualityControl"": ""qc:Z""
                        },
                        ""precipitationLast6Hours"": {
                            ""value"": null,
                            ""unitCode"": ""unit:m"",
                            ""qualityControl"": ""qc:Z""
                        },
                        ""relativeHumidity"": {
                            ""value"": 61.953298718645101,
                            ""unitCode"": ""unit:percent"",
                            ""qualityControl"": ""qc:C""
                        },
                        ""windChill"": {
                            ""value"": -11.147724771885066,
                            ""unitCode"": ""unit:degC"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""heatIndex"": {
                            ""value"": null,
                            ""unitCode"": ""unit:degC"",
                            ""qualityControl"": ""qc:V""
                        },
                        ""cloudLayers"": [
                            {
                                ""base"": {
                                    ""value"": 1430,
                                    ""unitCode"": ""unit:m""
                                },
                                ""amount"": ""FEW""
                            }
                        ]
                    }
                }";
            }
        }

        string AllStations
        {
            get
            {
                return @"{
                    ""@context"": [
                        ""https://raw.githubusercontent.com/geojson/geojson-ld/master/contexts/geojson-base.jsonld"",
                        {
                            ""wx"": ""https://api.weather.gov/ontology#"",
                            ""s"": ""https://schema.org/"",
                            ""geo"": ""http://www.opengis.net/ont/geosparql#"",
                            ""unit"": ""http://codes.wmo.int/common/unit/"",
                            ""@vocab"": ""https://api.weather.gov/ontology#"",
                            ""geometry"": {
                                ""@id"": ""s:GeoCoordinates"",
                                ""@type"": ""geo:wktLiteral""
                            },
                            ""city"": ""s:addressLocality"",
                            ""state"": ""s:addressRegion"",
                            ""distance"": {
                                ""@id"": ""s:Distance"",
                                ""@type"": ""s:QuantitativeValue""
                            },
                            ""bearing"": {
                                ""@type"": ""s:QuantitativeValue""
                            },
                            ""value"": {
                                ""@id"": ""s:value""
                            },
                            ""unitCode"": {
                                ""@id"": ""s:unitCode"",
                                ""@type"": ""@id""
                            },
                            ""forecastOffice"": {
                                ""@type"": ""@id""
                            },
                            ""forecastGridData"": {
                                ""@type"": ""@id""
                            },
                            ""publicZone"": {
                                ""@type"": ""@id""
                            },
                            ""county"": {
                                ""@type"": ""@id""
                            },
                            ""observationStations"": {
                                ""@container"": ""@list"",
                                ""@type"": ""@id""
                            }
                        }
                    ],
                    ""type"": ""FeatureCollection"",
                    ""features"": [
                        {
                            ""id"": ""https://api.weather.gov/stations/KSLC"",
                            ""type"": ""Feature"",
                            ""geometry"": {
                                ""type"": ""Point"",
                                ""coordinates"": [
                                    -111.96503,
                                    40.770690000000002
                                ]
                            },
                            ""properties"": {
                                ""@id"": ""https://api.weather.gov/stations/KSLC"",
                                ""@type"": ""wx:ObservationStation"",
                                ""elevation"": {
                                    ""value"": 1288.0848000000001,
                                    ""unitCode"": ""unit:m""
                                },
                                ""stationIdentifier"": ""KSLC"",
                                ""name"": ""Salt Lake City, Salt Lake City International Airport"",
                                ""timeZone"": ""America/Denver""
                            }
                        },
                        {
                            ""id"": ""https://api.weather.gov/stations/KLGU"",
                            ""type"": ""Feature"",
                            ""geometry"": {
                                ""type"": ""Point"",
                                ""coordinates"": [
                                    -111.85187000000001,
                                    41.786520000000003
                                ]
                            },
                            ""properties"": {
                                ""@id"": ""https://api.weather.gov/stations/KLGU"",
                                ""@type"": ""wx:ObservationStation"",
                                ""elevation"": {
                                    ""value"": 1355.1408000000001,
                                    ""unitCode"": ""unit:m""
                                },
                                ""stationIdentifier"": ""KLGU"",
                                ""name"": ""Logan-Cache Airport"",
                                ""timeZone"": ""America/Denver""
                            }
                        },
                        {
                            ""id"": ""https://api.weather.gov/stations/PAPB"",
                            ""type"": ""Feature"",
                            ""geometry"": {
                                ""type"": ""Point"",
                                ""coordinates"": [
                                    -169.66139000000001,
                                    56.578609999999998
                                ]
                            },
                            ""properties"": {
                                ""@id"": ""https://api.weather.gov/stations/PAPB"",
                                ""@type"": ""wx:ObservationStation"",
                                ""elevation"": {
                                    ""value"": 38.100000000000001,
                                    ""unitCode"": ""unit:m""
                                },
                                ""stationIdentifier"": ""PAPB"",
                                ""name"": ""St. George, St. George Airport"",
                                ""timeZone"": ""America/Nome""
                            }
                        }
                    ],
                    ""observationStations"": [
                        ""https://api.weather.gov/stations/KSLC"",
                        ""https://api.weather.gov/stations/KLGU"",
                        ""https://api.weather.gov/stations/PAPB""
                    ]
                }";
            }
        }
    }
}
