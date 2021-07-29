using System;
using System.Collections.Generic;
using System.Text;

namespace NWS.Model
{
    /// <summary>
    /// A NWS weather station
    /// </summary>
    public class WeatherStation
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string StationIdentifier { get; set; }
        public string Name { get; set; }
        public decimal ElevationInMeters { get; set; }
    }
}
