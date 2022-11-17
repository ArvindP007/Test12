using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitTestDemo.Models;

namespace UnitTestDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //throw new NotImplementedException();
            return View("Index");
        }
    }
}