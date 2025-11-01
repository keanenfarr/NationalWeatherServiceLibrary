using System;
using System.Net;
using System.Threading.Tasks;

namespace NWS.ConsoleDemoApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Get latitude and longitude from args or prompt user
            string latString = (args.Length > 0 && args[0] != null) ? args[0] : PromptForLatitude();
            string longString = (args.Length > 1 && args[1] != null) ? args[1] : PromptForLongitude();

            // Parse the strings to decimals
            if (!decimal.TryParse(latString, out decimal latitude))
            {
                Console.WriteLine($"Error: Invalid latitude '{latString}'. Please provide a valid decimal number.");
                return;
            }

            if (!decimal.TryParse(longString, out decimal longitude))
            {
                Console.WriteLine($"Error: Invalid longitude '{longString}'. Please provide a valid decimal number.");
                return;
            }

            Console.WriteLine($"Using coordinates: Latitude {latitude}, Longitude {longitude}");
            Console.WriteLine();

            //Needs to be RFC 7231 compliant: ProductName/Version (Comment)
            var webClient = new NWS.WebClient.Default.WebClient("jts599NWSConsoleDemoApp/1.0");

            var service = new NWS.WeatherDataService.WeatherDataService(webClient);

            var currentConditions = await service.GetCurrentConditionsAsync(latitude, longitude);

            if (currentConditions != null)
            {
                Console.WriteLine();
                Console.WriteLine($"STATION INFORMATION ----------------");
                Console.WriteLine($"Station: {currentConditions.Station.Name} ({currentConditions.Station.StationIdentifier}):");
                Console.WriteLine($"Station Elevation in Meters: {currentConditions.Station.ElevationInMeters}");
                Console.WriteLine($"Station Coordinates: {currentConditions.Station.Latitude}, {currentConditions.Station.Longitude}");
                Console.WriteLine();
                Console.WriteLine($"CURRENT CONDITIONS -----------------");
                Console.WriteLine($"Observation Date: {currentConditions.ObservationDate}");
                Console.WriteLine($"Summary: {currentConditions.TextDescription}");

                if (currentConditions.TemperatureFahrenheit.HasValue)
                {
                    Console.WriteLine($"Temperature (F): {currentConditions.TemperatureFahrenheit}");
                }

                if (currentConditions.TemperatureCelsius.HasValue)
                {
                    Console.WriteLine($"Temperature (C): {currentConditions.TemperatureCelsius}");
                }

                if (currentConditions.BarometricPressure.HasValue)
                {
                    Console.WriteLine($"Barometric Pressure: {currentConditions.BarometricPressure}");
                }

                if (currentConditions.DewPointFahrenheit.HasValue)
                {
                    Console.WriteLine($"Dew Point (F): {currentConditions.DewPointFahrenheit}");
                }

                if (currentConditions.HeatIndexFahrenheit.HasValue)
                {
                    Console.WriteLine($"Heat Index (F): {currentConditions.HeatIndexFahrenheit}");
                }

                if (currentConditions.RelativeHumidityPercent.HasValue)
                {
                    Console.WriteLine($"Relative Humidity: {currentConditions.RelativeHumidityPercent}");
                }

                if (currentConditions.SeaLevelPressure.HasValue)
                {
                    Console.WriteLine($"Sea Level Pressure: {currentConditions.SeaLevelPressure}");
                }

                if (currentConditions.VisibilityMeters.HasValue)
                {
                    Console.WriteLine($"Visibility in Meters: {currentConditions.VisibilityMeters}");
                }

                if (currentConditions.WindChillFahrenheit.HasValue)
                {
                    Console.WriteLine($"Wind Chill (F): {currentConditions.WindChillFahrenheit}");
                }

                if (currentConditions.WindGustMilesPerHour.HasValue)
                {
                    Console.WriteLine($"Wind Gust (MPH): {currentConditions.WindGustMilesPerHour}");
                }

                if (currentConditions.WindSpeedMilesPerHour.HasValue)
                {
                    Console.WriteLine($"Wind Speed (MPH): {currentConditions.WindSpeedMilesPerHour}");
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
                Console.WriteLine($"Last updated date: {forecast.LastUpdatedDate}");
                Console.WriteLine($"Elevation in Meters: {forecast.ElevationInMeters}");
                Console.WriteLine($"Latitude: {forecast.Latitude}");
                Console.WriteLine($"Longitude: {forecast.Longitude}");

                foreach (var period in forecast.Periods)
                {
                    Console.WriteLine();
                    Console.WriteLine($"From {period.StartTime} to {period.EndTime}:");
                    Console.WriteLine($"Name: {period.Name}");
                    Console.WriteLine($"Long Forecast: {period.ForecastLong}");
                    Console.WriteLine($"Short Forecast: {period.ForecastShort}");
                    Console.WriteLine($"Is Day Time? {period.IsDayTime}");
                    Console.WriteLine($"Temperature (F): {period.TemperatureInFahrenheit}");
                    Console.WriteLine($"Wind Direction: {period.WindDirection}");
                    Console.WriteLine($"Wind Speed: {period.WindSpeed}");
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

        static string PromptForLatitude()
        {
            string latitudeStr = string.Empty;
            while (string.IsNullOrEmpty(latitudeStr))
            {
                Console.WriteLine("Enter latitude:");
                latitudeStr = Console.ReadLine();

                if (string.IsNullOrEmpty(latitudeStr))
                {
                    Console.WriteLine("Invalid latitude! Try again.");
                }
            }
            return latitudeStr;
        }

        static string PromptForLongitude()
        {
            string longitudeStr = string.Empty;
            while (string.IsNullOrEmpty(longitudeStr))
            {
                Console.WriteLine("Enter longitude:");
                longitudeStr = Console.ReadLine();

                if (string.IsNullOrEmpty(longitudeStr))
                {
                    Console.WriteLine("Invalid longitude! Try again.");
                }
            }
            return longitudeStr;
        }
    }
}