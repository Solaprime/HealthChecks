using Newtonsoft.Json;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp.Repository
{
    public class IDataApiRepo : IDataRepo
    {
       

        //public Task GetBook(Guid Id)
        //{
        //    // throw new NotImplementedException();
        //    return null;
        //}

        public async  Task<IEnumerable<WeatherForecast>> GetWeather()
        {
            HttpClient client = new HttpClient();
            var respone = await client.GetAsync("https://localhost:44335/weatherforecast");
            var responseBody = await respone.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(responseBody);
            return responseObject;

            //return null;
        }
    }
}
