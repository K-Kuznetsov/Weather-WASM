using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Shared
{
    public class CurrentWeather
    {
        public double CurrTemp { get; set; }
        public double CurrWind { get; set; }
        public double FeelsLike { get; set; }
        public string CurrSummary { get; set; }
        public string CurrICON { get; set; }
    }
}
