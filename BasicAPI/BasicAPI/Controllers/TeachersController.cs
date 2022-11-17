using Microsoft.AspNetCore.Mvc;
using BasicAPI.Data;
using BasicAPI.Model;

namespace BasicAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class TeachersController : Controller
    {
        /*private readonly ITechRepository _teacher;
        public TeachersController(ITechRepository teacher)
        {
            _teacher = teacher;
        }*/
        private readonly DataContext _context;

        public TeachersController(DataContext context)
        {
            _context = context;
        }
       // [HttpPost("Register")]
        public async Task<ActionResult<int>> Register(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return Ok(teacher);
        }
       // [HttpPost("login")]
        public async Task<ActionResult<string>> Login(Teacher tName)
        {
            var user = await _context.Teachers.FindAsync(tName.Username);
            if(user == null)
            {
                return BadRequest("User not found");
            }
            return "Found";
        }
    }
}
