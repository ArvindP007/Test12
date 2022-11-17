using AutoMapper;
using Library_WebAPI.Data;
using Library_WebAPI.Dtos;
using Library_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_WebAPI.Services
{
    public class BookService : IBookService
    { 
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public BookService(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetBookDto>> AddBook(AddBookDto newBook)
        {
            Book book = _mapper.Map<Book>(newBook);
            var result = _context.Books.Add(book);
            _context.SaveChanges();
            var res = await _context.Books
                .Select(c => _mapper.Map<GetBookDto>(c))
                .ToListAsync();
            return res;
            /*var serviceResponse = new ServiceResponse<List<GetBookDto>>();
            Book book = _mapper.Map<Book>(newBook);
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.Books
                .Select(c => _mapper.Map<GetBookDto>(c))
                .ToListAsync();
            return serviceResponse;*/
        }

        public async Task<ServiceResponse<List<GetBookDto>>> DeleteBook(int id)
        {
            ServiceResponse<List<GetBookDto>> serviceResponse = new ServiceResponse<List<GetBookDto>>();
            Book book = await _context.Books.FirstOrDefaultAsync(c => c.Id == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                serviceResponse.Data = _context.Books
                    .Select(c => _mapper.Map<GetBookDto>(c)).ToList();               
            }
            else
            {
                serviceResponse.Message = "Book Not found";
            }
            return serviceResponse;
        }

        public async Task<List<GetBookDto>> GetAllBooks()
        {
            // var response = new ServiceResponse<List<GetBookDto>>();
            //var db = await _context.Books.ToListAsync();
            // response.Data = db.Select(c => _mapper.Map<GetBookDto>(c)).ToList();
            try
            {
                var res = await _context.Books
                 .Select(c => _mapper.Map<GetBookDto>(c))
                 .ToListAsync();
                return res;
            }
  
            catch(Exception e)
            {
                throw new NullReferenceException();
            }
        }

        public async Task<ServiceResponse<GetBookDto>> GetBookyById(int id)
        {
            var serviceResponse = new ServiceResponse<GetBookDto>();
            var db = _context.Books
                .FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetBookDto>(db);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetBookDto>> UpdateBook(UpdateBookDto updateBook)
        {
            ServiceResponse<GetBookDto> serviceResponse = new ServiceResponse<GetBookDto>();
            try
            {
                var book = await _context.Books.FirstOrDefaultAsync(c => c.Id == updateBook.Id);

                if (book != null)
                {
                    book.BookName = updateBook.BookName;
                    book.Author = updateBook.Author;
                    book.Price = updateBook.Price;
                    await _context.SaveChangesAsync();

                    serviceResponse.Data = _mapper.Map<GetBookDto>(book);
                }
                else
                {
                    serviceResponse.Message = "Book Not found";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }
        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.ToListAsync();
        }
    }
}
