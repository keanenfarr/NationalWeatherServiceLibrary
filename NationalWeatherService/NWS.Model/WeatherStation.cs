using System;
using System.Collections.Generic;
using System.Text;

namespace NWS.Model
{
    public class WeatherStation
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string StationIdentifier { get; set; }
        public string Name { get; set; }
    }
}
