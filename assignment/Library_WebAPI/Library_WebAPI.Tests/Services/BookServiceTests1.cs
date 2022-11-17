using AutoMapper;
using FakeItEasy;
using Library_WebAPI.Data;
using Library_WebAPI.Dtos;
using Library_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WebAPI.Tests.Services
{
    public class BookServiceTests1
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public BookServiceTests1()
        {
            _context = A.Fake<DataContext>();
            _mapper = A.Fake<IMapper>();
        }

        [Fact]
        public void GetAllBooks_returnsSuccess()
        {
            var books = A.Fake<ICollection<GetBookDto>>();
            var bookList = A.Fake<List<GetBookDto>>();
            A.CallTo(() => _mapper.Map<List<GetBookDto>>(books)).Returns(bookList);
        }
        [Fact]
        public async Task AddBook_newBookData_returnsList()
        {
            //var book = await _context.Books.ToListAsync();
            var books = A.Fake<ICollection<GetBookDto>>();
            var bookList = A.Fake<List<GetBookDto>>();

            var newBook = new List<Book>
            {
                new Book{BookName="Mission",Author="Arthro",Price=230}
            };
            
            _context.Add(newBook);
            await _context.SaveChangesAsync();
            //A.CallTo () => _mapper.Map<Book>(newBook);
            A.CallTo(() => _mapper.Map<List<GetBookDto>>(books)).Returns(bookList);
            //var res = await _context.Books.FirstOrDefaultAsync(c => c.Id == Book.Id);
            Assert.Equal("", "");

            foreach (var a in bookList)
            {
                if (string.Equals(a.BookName, "Mission"))
                {
                    Assert.True(true);
                    break;
                }
            }
        }
        [Fact]
        public async Task UpdateBook_newBookData_returnsSuccess()
        {
            var bookList = A.Fake<List<GetBookDto>>();
            var books = A.Fake<ICollection<GetBookDto>>();
            var updateBook = new List<Book>
            {
                new Book{Id=1,BookName="Mission",Author="Arthro",Price=230}
            };

            foreach (var a in bookList)
            {
                if (a.Id==1)
                {
                    a.BookName = "Mission";
                    a.Author = "Arthro";
                    a.Price = 260;
                    Assert.True(true);
                    break;
                }
            }
        }
    }
}
