namespace DI_WebApplication.Models
{
    public class StudentService: IStudentServices
    {
        public string GetStudentName()
        {
            string StudentName = "Arvind";
            return StudentName;
        }
        public List<Students> GetStudentsList()
        {
            List<Students> studentList = new List<Students>();
            studentList.Add(new Students { StudentId = 1, StudentName = "John" });
            studentList.Add(new Students { StudentId = 2, StudentName = "Jack" });
            return studentList;
        }
    }
}
