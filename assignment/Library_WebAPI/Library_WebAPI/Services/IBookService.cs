using Library_WebAPI.Dtos;
using Library_WebAPI.Models;

namespace Library_WebAPI.Services
{
    public interface IBookService
    {
        Task<List<GetBookDto>> GetAllBooks();
        Task<List<Book>> GetAllAsync();
        Task<ServiceResponse<GetBookDto>> GetBookyById(int Id);
        Task<List<GetBookDto>> AddBook(AddBookDto newBook);
        Task<ServiceResponse<GetBookDto>> UpdateBook(UpdateBookDto updateBook);
        Task<ServiceResponse<List<GetBookDto>>> DeleteBook(int Id);
    }
}