using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicAPI.Controllers;
using BasicAPI.Data;
using BasicAPI.Model;
using FakeItEasy;
using FluentAssertions;

namespace BasicAPI.Tests.Controller
{
    public class StudentsControllerTest
    {
        private readonly DataContext _context;

        public StudentsControllerTest()
        {
            _context = A.Fake<DataContext>();
        }
        [Fact]
        public void StudentsController_GetAllStudents_ReturnsSuccess()
        {
            //Arrange
            var student = A.Fake<IEnumerable<Student>>();
            var studentList = A.Fake<List<Student>>();
            A.CallTo(() => A.Fake<List<Student>>(student)).Returns(studentList);
            var controller = new StudentsController(_context);
            //Act
            var result = controller.GetAllStudents();
            //Assert
            result.Should().NotBeNull();
        }
        [Fact]
        public void StudentsController_GetStudentById_ReturnOk()
        {
            int id = 1;
            var student = A.Fake<Student>();
            var studentList = A.Fake<List<Student>>();
            var controller = new StudentsController(_context);
            object value = A.CallTo(() => controller.GetAllStudents()).Where(i => i.Id == id).Select(c => new Student()
            {
                Id = c.Id,
                Name = c.Name,
                RollNo = c.RollNo
            }).FirstOrDefaultAsync().Returns(student);

            var result = controller.Get(id);
            result.Should().NotBeNull();
        }
        //[Fact]
        public void StudentsController_AddStudent_ReturnOk()
        {

        }
        //[Fact]
        public void StudentsController_UpdateStudent_ReturnOk()
        {

        }
        //[Fact]
        public void StudentsController_DeleteStudent_ReturnsSuccess()
        {

        }
    }
}
