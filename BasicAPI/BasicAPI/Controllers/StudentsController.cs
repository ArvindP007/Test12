using Microsoft.AspNetCore.Mvc;
using BasicAPI.Model;
using Microsoft.EntityFrameworkCore;
using BasicAPI.Data;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //private readonly IStudentService _studentService;
        private readonly DataContext _context;

        public StudentsController(DataContext context)
        {
            _context = context;
        }/*
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return Ok(await _context.Students.ToListAsync());
        }*/
        [HttpGet]
        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            students.AddRange(_context.Students);
            return students;
        }
        [HttpGet("Id")]
        public async Task<ActionResult<List<Student>>> Get(int id)
        {
            Student students = null;
                students = await _context.Students.Where(i => i.Id == id).Select(c => new Student(){
                        Id = c.Id,
                        Name = c.Name,
                        RollNo = c.RollNo
                    }).FirstOrDefaultAsync() ;
            return Ok(students);
        }
        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
        [HttpPut("Id")]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student request)
        {
            var student = await _context.Students.FindAsync(request.Id);
            if(student == null)
            {
                return BadRequest("Student Not found");
            }
            student.Name= request.Name; 
            student.RollNo= request.RollNo;
           // _context.Students.Update(student);
            await _context.SaveChangesAsync();

            return Ok(await _context.Students.ToListAsync());
        }
        [HttpDelete("Id")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return BadRequest("Student Not found");
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
    }
}
