using CarWorkshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            var model = new About()
            {
                Title = "CarWorkShop application",
                Description = "Some description",
                Tags = new List<string>() { "Car","app", "free"}
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            var lista = new List<Person>()
            {
                new Person()
                {
                    Name = "Michał",
                    LastName = "Szalaty"
                },
                new Person()
                {
                    Name = "Tomek",
                    LastName = "Siudzinski"
                }
            };

            return View(lista);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}