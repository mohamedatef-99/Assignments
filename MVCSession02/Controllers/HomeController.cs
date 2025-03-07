using Microsoft.AspNetCore.Mvc;

namespace MVCSession02.Controllers
{

    // View: HTML Page
    // Razor Page: HTML Page with C# Code
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
