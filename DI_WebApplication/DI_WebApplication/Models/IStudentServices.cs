namespace DI_WebApplication.Models
{
    public interface IStudentServices
    {
        public string GetStudentName();
        public List<Students> GetStudentsList();
    }
}