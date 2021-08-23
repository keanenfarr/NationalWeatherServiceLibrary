namespace NWS.WeatherDataService
{
    /// <summary>
    /// A utilities class for easy access to conversion utilities
    /// </summary>
    public static class Utilities
    {
        public static decimal ConvertCelsiusToFahrenheit(decimal celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static decimal ConvertMetersPerSecondToMilesPerHour(decimal speed)
        {
            return speed * 2.23694m;
        }

        public static decimal ConvertKilometersPerHourToMilesPerHour(decimal speed)
        {
            return speed / 1.609m;
        }
    }
}
