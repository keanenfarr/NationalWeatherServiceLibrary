using System;
using System.Threading.Tasks;

namespace NWS.ConsoleDemoApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            decimal latitude = 0;
            decimal longitude = 0;
            string latitudeStr = string.Empty;
            string longitudeStr = string.Empty;

            while (string.IsNullOrEmpty(latitudeStr) || latitude == 0)
            {
                Console.WriteLine("Enter latitude:");
                latitudeStr = Console.ReadLine();

                decimal.TryParse(latitudeStr, out latitude);

                if (string.IsNullOrEmpty(latitudeStr) || latitude == 0)
                {
                    Console.WriteLine("Invalid latitude! Try again.");
                }
            }

            while (string.IsNullOrEmpty(longitudeStr) || longitude == 0)
            {
                Console.WriteLine("Enter longitude:");
                longitudeStr = Console.ReadLine();

                decimal.TryParse(longitudeStr, out longitude);

                if (string.IsNullOrEmpty(longitudeStr) || longitude == 0)
                {
                    Console.WriteLine("Invalid longitude! Try again.");
                }
            }

            var service = new NWS.WeatherDataService.WeatherDataService();

            var currentConditions = await service.GetCurrentConditionsAsync(latitude, longitude);

            if (currentConditions != null)
            {
                Console.WriteLine();
                Console.WriteLine($"STATION INFORMATION ----------------");
                Console.WriteLine($"Station: { currentConditions.Station.Name } ({ currentConditions.Station.StationIdentifier }):");
                Console.WriteLine($"Station Elevation in Meters: { currentConditions.Station.ElevationInMeters }");
                Console.WriteLine($"Station Coordinates: { currentConditions.Station.Latitude }, { currentConditions.Station.Longitude }");
                Console.WriteLine();
                Console.WriteLine($"CURRENT CONDITIONS -----------------");
                Console.WriteLine($"Observation Date: { currentConditions.ObservationDate }");
                Console.WriteLine($"Summary: { currentConditions.TextDescription }");

                if (currentConditions.TemperatureFahrenheit.HasValue)
                {
                    Console.WriteLine($"Temperature (F): { currentConditions.TemperatureFahrenheit }");
                }

                if (currentConditions.TemperatureCelsius.HasValue)
                {
                    Console.WriteLine($"Temperature (C): { currentConditions.TemperatureCelsius }");
                }

                if (currentConditions.BarometricPressure.HasValue)
                {
                    Console.WriteLine($"Barometric Pressure: { currentConditions.BarometricPressure }");
                }

                if (currentConditions.DewPointFahrenheit.HasValue)
                {
                    Console.WriteLine($"Dew Point (F): { currentConditions.DewPointFahrenheit }");
                }

                if (currentConditions.HeatIndexFahrenheit.HasValue)
                {
                    Console.WriteLine($"Heat Index (F): { currentConditions.HeatIndexFahrenheit }");
                }

                if (currentConditions.RelativeHumidityPercent.HasValue)
                {
                    Console.WriteLine($"Relative Humidity: { currentConditions.RelativeHumidityPercent }");
                }

                if (currentConditions.SeaLevelPressure.HasValue)
                {
                    Console.WriteLine($"Sea Level Pressure: { currentConditions.SeaLevelPressure }");
                }

                if (currentConditions.VisibilityMeters.HasValue)
                {
                    Console.WriteLine($"Visibility in Meters: { currentConditions.VisibilityMeters }");
                }

                if (currentConditions.WindChillFahrenheit.HasValue)
                {
                    Console.WriteLine($"Wind Chill (F): { currentConditions.WindChillFahrenheit }");
                }

                if (currentConditions.WindGustMilesPerHour.HasValue)
                {
                    Console.WriteLine($"Wind Gust (MPH): { currentConditions.WindGustMilesPerHour }");
                }

                if (currentConditions.WindSpeedMilesPerHour.HasValue)
                {
                    Console.WriteLine($"Wind Speed (MPH): { currentConditions.WindSpeedMilesPerHour }");
                }
            }
            else
            {
                Console.WriteLine("No current conditions found.");
            }

            Console.WriteLine();
            Console.WriteLine($"FORECAST ---------------------------");

            var forecast = await service.GetForecastAsync(latitude, longitude);

            if (forecast != null)
            {
                Console.WriteLine($"Last updated date: { forecast.LastUpdatedDate }");
                Console.WriteLine($"Elevation in Meters: { forecast.ElevationInMeters }");
                Console.WriteLine($"Latitude: { forecast.Latitude }");
                Console.WriteLine($"Longitude: { forecast.Longitude }");

                foreach (var period in forecast.Periods)
                {
                    Console.WriteLine();
                    Console.WriteLine($"From { period.StartTime } to { period.EndTime }:");
                    Console.WriteLine($"Name: { period.Name }");
                    Console.WriteLine($"Long Forecast: { period.ForecastLong }");
                    Console.WriteLine($"Short Forecast: { period.ForecastShort }");
                    Console.WriteLine($"Is Day Time? { period.IsDayTime }");
                    Console.WriteLine($"Temperature (F): { period.TemperatureInFahrenheit }");
                    Console.WriteLine($"Wind Direction: { period.WindDirection }");
                    Console.WriteLine($"Wind Speed: { period.WindSpeed }");
                }
            }
            else
            {
                Console.WriteLine("Forecast was null.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("THE END. Press enter to quit.");
            Console.ReadLine();
        }
    }
}