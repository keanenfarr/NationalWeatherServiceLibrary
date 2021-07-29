using System;

namespace NWS.Model
{
    /// <summary>
    /// Current weather conditions
    /// </summary>
    public class CurrentConditionsResponse
    {
        public DateTime ObservationDate { get; set; }

        public WeatherStation WeatherStation { get; set; }

        public decimal? TemperatureFahrenheit { get; set; }

        public decimal? TemperatureCelsius { get; set; }

        public string TextDescription { get; set; }

        public decimal? DewPointCelsius { get; set; }

        public decimal? DewPointFahrenheit { get; set; }

        public decimal? WindDirection { get; set; }

        public decimal? WindSpeedMetersPerSecond { get; set; }

        public decimal? WindSpeedMilesPerHour { get; set; }

        public decimal? WindGustMetersPerSecond { get; set; }

        public decimal? WindGustMilesPerHour { get; set; }

        public decimal? BarometricPressure { get; set; }

        public decimal? SeaLevelPressure { get; set; }

        public decimal? VisibilityMeters { get; set; }

        public decimal? RelativeHumidityPercent { get; set; }

        public decimal? WindChillCelsius { get; set; }

        public decimal? WindChillFahrenheit { get; set; }

        public decimal? HeatIndexCelsius { get; set; }

        public decimal? HeatIndexFahrenheit { get; set; }

        public string RawData { get; set; }

        /// <summary>
        /// The station that provided the conditions.
        /// </summary>
        public WeatherStation Station { get; set; }
    }
}
