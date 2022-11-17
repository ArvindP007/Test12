using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public void SampleDemoLogging()
        {
            _logger.LogTrace("This is a trace log");
            _logger.LogCritical("This is a critical log");
            _logger.LogDebug("This is Debug log");
            _logger.LogError("This is a Error log");
            _logger.LogWarning("This is warning log");
            _logger.LogInformation("This is Information log");
        }
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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