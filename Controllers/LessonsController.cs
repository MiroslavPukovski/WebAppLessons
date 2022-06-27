using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class LessonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jokes()
        {
            return View();
        }

        public IActionResult Processors()
        {
            return View();
        }

        public IActionResult BookLibrary()
        {
            return View();
        }
    }
}
