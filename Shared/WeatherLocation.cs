using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Shared
{
    public class WeatherLocation
    {
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }        
        public string LocalTime { get; set; }
    }
}
