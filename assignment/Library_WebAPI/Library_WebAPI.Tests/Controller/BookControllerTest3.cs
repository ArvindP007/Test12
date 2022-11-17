using Library_WebAPI.Controllers;
using Library_WebAPI.Services;
using Library_WebAPI.Tests.MockData;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WebAPI.Tests.Controller
{
    public class BookControllerTest3
    {
        [Fact]
        public async Task GetAllAsync_ShouldReturn200Status()
        {
            /// Arrange
            var todoService = new Mock<IBookService>();
            todoService.Setup(_ => _.GetAllAsync()).ReturnsAsync(MockBookData.GetBooks());
            var sut = new BookController(todoService.Object);

            /// Act
            var result = (OkObjectResult)await sut.GetAllAsync();


            // /// Assert
            result.StatusCode.Should().Be(200);
        }
    }
}
