using Library_WebAPI.Models;
using Library_WebAPI.Services;
using Library_WebAPI.Dtos;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using Library_WebAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
//using FluentAssertions;

namespace Library_WebAPI.Tests.Controller
{
    public class BookControllerTest
    {
        private readonly IBookService _bookService;
        //private readonly Mock<IBookService> _bookService;
        public BookControllerTest()
        {
            //_bookService = new Mock<IBookService>();
        }

        [Fact]
        public async Task GetAll_returnsList()
        {
            var bookList = new List<GetBookDto>();
            // ServiceResponse serviceResponse = new ServiceResponse();
            // var result = await <List<GetBookDto>();

            // _bookService.Setup(p => p.GetAllBooks())
            //   .Returns(bookList);

            // Assert.NotNull(result);
            //Assert.True(bookList.Equals(result));

            var list = new List<GetBookDto>();

            var _bookService = new Mock<IBookService>();
            var sut = new BookController(_bookService.Object);
            _bookService.Setup(service => service.GetAllBooks());
               // .ReturnsAsync(new List<GetBookDto>());
            
            //var result = (OkObjectResult)await sut.GetAll();
        }
        [Fact]
        public async Task GetById_returnsList()
        {

        }
        [Fact]
        public async Task AddBook_returnsList()
        {

        }
        [Fact]
        public async Task DeleteBook_returnsList()
        {

        }
        [Fact]
        public async Task UpdateBook_returnsList()
        {

        }

    }
}
