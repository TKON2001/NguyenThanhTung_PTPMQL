using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name = "User", int numTimes = 1)
        {
            ViewBag.Message = $"Hello {name}!";
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}
