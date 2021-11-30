using Microsoft.AspNetCore.Mvc;
using WeatherForecastApp.Models;

namespace WeatherForecastApp.Controllers
{
    public class WeatherForecastController : Controller
    {

        [HttpGet]
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View(viewModel);
        }


        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City","WeatherForecast",new {city = model.CityName});
            }
            return View(model);
        }

        public IActionResult City(string city)
        {
            var viewModel = new City();
            return View(viewModel);
        }
    }
}
