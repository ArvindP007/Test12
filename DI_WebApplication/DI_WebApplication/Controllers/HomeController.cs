using DI_WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DI_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentServices _studentServices;
        public HomeController(IStudentServices studentServices)
        {
            _studentServices= studentServices;
        }
        
        public IActionResult Index()
        {
            string studentName = _studentServices.GetStudentName();
            var studentList = _studentServices.GetStudentsList();
            return View();
        }
        public List<Students> GetStudent()
        {
            string studentName = _studentServices.GetStudentName();
            var studentList = _studentServices.GetStudentsList();
            return studentList;
        }
    }
}