using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NETCOREAPI.Models;

namespace NETCOREAPI.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
            string strOutput = "Xin chào " + FullName + " đến từ " + Address;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}
