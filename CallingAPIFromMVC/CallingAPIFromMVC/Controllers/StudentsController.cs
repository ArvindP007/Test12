using CallingAPIFromMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CallingAPIFromMVC.Controllers
{
    public class StudentsController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();

        Student _student = new Student();
        List<Student> _students = new List<Student>();
        public StudentsController()
        {
            _clientHandler.ServerCertificateCustomValidationCallback = 
                (sender, cert, chain, sslPolicyErrors) => { return true; };
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<List<Student>> GetAllStudents()
        {
            _students=new List<Student>();
            using(var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44313/api/Students"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _students = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
                }
            }
            return _students;
        }
        [HttpGet]
        public async Task<Student> GetStudentById(int studentId)
        {
            _student = new Student();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44313/api/Students/" + studentId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _student = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return _student;
        }
        [HttpPost]
        public async Task<Student> AddUpdateStudent(Student student)
        {
            _student = new Student();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                StringContent content= new StringContent(JsonConvert.
                    SerializeObject(student),Encoding.UTF8,"application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44313/api/Students/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _student = JsonConvert.DeserializeObject<Student>(apiResponse);
                }
            }
            return _student;
        }
        [HttpDelete]
        public async Task<string> Delete(int studentId)
        {
            string message = "";
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44313/api/Students/" + studentId))
                {
                    message = await response.Content.ReadAsStringAsync();
                }
            }
            return message;
        }
    }
}
