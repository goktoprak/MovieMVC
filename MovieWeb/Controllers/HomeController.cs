using Microsoft.AspNetCore.Mvc;

namespace MovieWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NotFound()
        {
            return View();
        }
    }
}