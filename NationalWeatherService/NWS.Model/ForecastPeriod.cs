using System;
using System.Collections.Generic;
using System.Text;

namespace NWS.Model
{
    /// <summary>
    /// Represents a weather forecast for a defined period of time.
    /// </summary>
    public class ForecastPeriod
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDayTime { get; set; }
        public decimal TemperatureInFahrenheit { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public string ForecastShort { get; set; }
        public string ForecastLong { get; set; }
    }
}
