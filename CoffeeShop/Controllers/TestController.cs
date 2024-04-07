using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
