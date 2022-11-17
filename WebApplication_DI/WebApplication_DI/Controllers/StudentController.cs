using Microsoft.AspNetCore.Mvc;
using WebApplication_DI.Infrastructure;

namespace WebApplication_DI.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentRepo _repo;
        public StudentController(ILogger<StudentController> logger, IStudentRepo repo)
        {
            _logger = logger;
            _repo = repo;

        }
        public IActionResult Index()
        {
            var items = _repo.GetAll();
            return View(items);
        }
        public IActionResult Details(int id)
        {
            var items = _repo.GetById(id);
            return View(items);
        }
    }
}
