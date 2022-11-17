using WebApplication_DI.Data;
using WebApplication_DI.Infrastructure;
using WebApplication_DI.Models;

namespace WebApplication_DI.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDbContext _content;
        public StudentRepo(ApplicationDbContext content)
        {
            _content = content;
        }
        public List<Student> GetAll()
        {
            return _content.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _content.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
