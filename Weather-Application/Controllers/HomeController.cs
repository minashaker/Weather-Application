using Microsoft.AspNetCore.Mvc;
using Weather_Application.Models;
using Weather_Application.ViewModels;

namespace Weather_Application.Controllers
{
    public class HomeController : Controller
    {
        private readonly CityWeatherViewModel _cityWeather = new CityWeatherViewModel()
        {
            CityWeather =
            [
                new CityWeather()
                {
                    CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
                    TemperatureFahrenheit = 33
                },

                new CityWeather()
                {
                    CityUniqueCode = "NYC", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),
                    TemperatureFahrenheit = 60
                },

                new CityWeather()
                {
                    CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),
                    TemperatureFahrenheit = 82
                }
            ],
        };
        
        
        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.title = "Home";
            /*ViewBag.weather = _cityWeather;*/
            return View(_cityWeather);
        }
        
        [Route("/details/{uniqueCode}")]
        public IActionResult Details(string? uniqueCode)
        {
            if (int.TryParse(uniqueCode, out var result))
            {
                TempData["message"] = "uniqueCode is not a string";
                return RedirectToAction("Index");
            }
            CityWeather? cityWeather = _cityWeather?.CityWeather?.First((c) => c.CityUniqueCode == uniqueCode);
            
            ViewBag.title = cityWeather?.CityUniqueCode;
            
            return View(cityWeather);
        }
    }
}
