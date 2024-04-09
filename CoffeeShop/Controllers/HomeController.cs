using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
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
            var lectures = new List<Lecture>
        {
            new Lecture { Id = 1, Name = "Лекция 1", Description = "Описание лекции 1" },
            new Lecture { Id = 2, Name = "Лекция 2", Description = "Описание лекции 2" },
            new Lecture { Id = 3, Name = "Лекция 3", Description = "Описание лекции 3" }
        };
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Lecture1()
        {
            return View();
        }

        public IActionResult Lecture2()
        {
            return View();
        }

        public IActionResult Lecture3()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
