using AutoMapper;
using Library_WebAPI.Data;
using Library_WebAPI.Services;
using Library_WebAPI.Tests.MockData;
using Microsoft.EntityFrameworkCore;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WebAPI.Tests.Services
{
    public class BookServiceTests3 : IDisposable
    {
        protected readonly DataContext _context;
        protected readonly IMapper _mapper;
        public BookServiceTests3()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            _context = new DataContext(options);

            _context.Database.EnsureCreated();
        }
        [Fact]
        public async Task GetAllAsync_ReturnTodoCollection()
        {
            /// Arrange
            _context.Books.AddRange(MockData.MockBookData.GetBooks());
            _context.SaveChanges();

            var sut = new BookService(_context,_mapper);

            /// Act
            var result = await sut.GetAllBooks();

            /// Assert
            result.Should().HaveCount(MockBookData.GetBooks().Count);
        }

        [Fact]
        public async Task SaveAsync_AddNewTodo()
        {
            /// Arrange
            var newBook = MockBookData.NewBook();
            _context.Books.AddRange(MockData.MockBookData.GetBooks());
            _context.SaveChanges();

            var sut = new BookService(_context,_mapper);

            /// Act
           // await sut.AddBook(newBook);

            ///Assert
            int expectedRecordCount = (MockBookData.GetBooks().Count() + 1);
            _context.Books.Count().Should().Be(expectedRecordCount);
        }
        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}
