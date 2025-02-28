using Microsoft.AspNetCore.Mvc;
using NETCOREAPI.Models; // Thêm dòng này để nhận diện class Person

namespace NETCOREAPI.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = $"Xin chào {ps.PersonId} - {ps.FullName} - {ps.Address}";
            ViewBag.InfoPerson = strOutput;

            return View();
        }
    }
}
