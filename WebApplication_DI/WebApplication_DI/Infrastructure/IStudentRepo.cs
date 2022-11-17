using WebApplication_DI.Models;

namespace WebApplication_DI.Infrastructure
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
        Student GetById(int id);
    }
}
