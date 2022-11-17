using AutoMapper;
using Library_WebAPI.Controllers;
using Library_WebAPI.Data;
using Library_WebAPI.Dtos;
using Library_WebAPI.Models;
using Library_WebAPI.Services;
using Moq;
using Xunit;

namespace Library_WebAPI.Tests.Services
{
    public class BookServiceTests
    {
        public Mock<DataContext> _context = new Mock<DataContext>();
        public Mock<IMapper> _mapper = new Mock<IMapper>();
        public Mock<BookService> bookServiceMock = new Mock<BookService>();
        public Mock<ServiceResponse<GetBookDto>> _response = new Mock<ServiceResponse<GetBookDto>>();

        [Fact]
        public  void GetBookyById_SuccessResult()
        {
            var result = new BookService(_context.Object, _mapper.Object);
            var result1 = result.GetBookyById(12);
            Assert.NotNull(result1);
        }
        [Fact]
        public async Task GetAllBooks_ReturnSuccess()
        {
            var result = new BookService(_context.Object, _mapper.Object);
            var result1 = await result.GetAllBooks();
            Assert.NotNull(result);
            var book = new List<Book>
            {
                new Book {BookName ="Tesla Model 3",Id=1},
                new Book {BookName ="Tesla Model S",Id=2},
                new Book {BookName ="Tesla Model X",Id=3}
            };
            //var bookDbSet = DataContext(collection.AsQueryable());
            /*
             var stubContext = new Mock<WingtipToysDbContext>();
            stubContext.Setup(o=>o.Products).Returns(productDbSet);
            var sut = new ProductRepository(stubContext.Object);
            //Act
            var actual = (List<Product>)sut.GetAll();
             */
            
        }
    }
}
