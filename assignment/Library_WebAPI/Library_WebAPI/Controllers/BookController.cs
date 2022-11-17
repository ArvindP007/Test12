using Library_WebAPI.Models;
using Library_WebAPI.Services;
using Library_WebAPI.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Library_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<GetBookDto>>> GetAll()
        {
            return Ok(await _bookService.GetAllBooks());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetBookDto>> GetById(int id)
        {
            return Ok(await _bookService.GetBookyById(id));
        }
        [HttpPost]
        public async Task<ActionResult<GetBookDto>> AddBook(AddBookDto newBook)
        {
            var res = await _bookService.AddBook(newBook);
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetBookDto>>> DeleteBook(int id)
        {
            var res = await _bookService.DeleteBook(id);
            if(res==null)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetBookDto>>> UpdateBook(UpdateBookDto updateBook)
        {
            var res = await _bookService.UpdateBook(updateBook);
            if (res == null)
            {
                return NotFound(res);
            }
            return Ok(res);
        }
        [Route("get-all")]
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _bookService.GetAllAsync();
            if (result.Count == 0)
            {
                return NoContent();
            }
            return Ok(result);
        }
    }
}
