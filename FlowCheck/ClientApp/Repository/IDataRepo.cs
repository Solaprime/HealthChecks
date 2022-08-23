using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Repository
{
    public  interface IDataRepo
    {
        Task<IEnumerable<WeatherForecast>> GetWeather();
     //   Task GetBook(Guid Id);
    }
}
