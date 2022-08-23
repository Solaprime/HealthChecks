using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.ViewModel
{
    public class WeatherForeCastViewModel
    {
        public IEnumerable<WeatherForecast> weather { get; set; }
    }
}
