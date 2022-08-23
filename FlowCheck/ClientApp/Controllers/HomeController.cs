using ClientApp.Models;
using ClientApp.Repository;
using ClientApp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataRepo _dataRepo;

        public HomeController(ILogger<HomeController> logger, IDataRepo datarepo)
        {
            _logger = logger;
            _dataRepo = datarepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async  Task<IActionResult> Test()
        {
            // return View(_dataRepo.GetWeather());
            WeatherForeCastViewModel model = new WeatherForeCastViewModel();
            model.weather =  await _dataRepo.GetWeather();
            return View(model);
        }
    }
}
