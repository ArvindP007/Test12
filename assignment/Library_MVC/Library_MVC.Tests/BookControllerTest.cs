using Library_MVC.Controllers;
using Library_MVC.Data;
using Library_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSupport.EfHelpers;

namespace Library_MVC.Tests
{
    public class BookControllerTest
    {

        [Fact]
        public void TestSqliteInMemoryOk()
        {
            //SETUP
            var options = SqliteInMemory.CreateOptions<DbContext>();
            using var context = new DbContext(options);

            context.Database.EnsureCreated();

            //Rest of test is left out
        }
        [Fact]
        public void Index_returnsSuccess()
        {
            var  mockSet = new Mock<DbSet<Book>>();
            var mockContext = new Mock<DbContext>();
            mockContext.Setup(m => m.Books).Returns(mockSet.Object);

            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
            var context = new DbContext(optionsBuilder.Options);

            var controller = new BookController(context);
            IEnumerable<Book> books = mockContext.Books;
            var result = controller.Index() as ViewResult;
            Assert.NotNull(books);
            //Assert.AreEqual("Details", result.BoName);
        }

        /*
         private BloggingContext _context;

        public BlogService(BloggingContext context)
        {
            _context = context;
        }

        public void CreateBlog_saves_a_blog_via_context()
        {
            var mockSet = new Mock<DbSet<Blog>>();

            var mockContext = new Mock<BloggingContext>();
            mockContext.Setup(m => m.Blogs).Returns(mockSet.Object);

            var service = new BlogService(mockContext.Object);
            service.AddBlog("ADO.NET Blog", "http://blogs.msdn.com/adonet");

            mockSet.Verify(m => m.Add(It.IsAny<Blog>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
         */
    }
}
