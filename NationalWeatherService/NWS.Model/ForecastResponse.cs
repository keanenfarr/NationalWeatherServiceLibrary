using System;
using System.Collections.Generic;
using System.Text;

namespace NWS.Model
{
    /// <summary>
    /// A weather forecast
    /// </summary>
    public class ForecastResponse
    {
        public IList<ForecastPeriod> Periods { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int ElevationInMeters { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string RawData { get; set; }
    }
}
