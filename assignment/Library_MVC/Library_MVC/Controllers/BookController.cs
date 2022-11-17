using Library_MVC.Data;
using Library_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_MVC.Controllers
{
    public class BookController : Controller
    {
        private readonly DataContext _db;
        public BookController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            // var books = _bookService.GetAllBooks();
            IEnumerable<Book> books = _db.Books;
            return View(books);
        }

        [HttpGet("id")]
        public IActionResult BookListById(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var book = _db.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBook(Book obj)
        {
            if (obj.BookName == obj.Id.ToString())
            {
                ModelState.AddModelError("name", "The Name and Id cannot be same.");
            }

            if (ModelState.IsValid)
            {
                _db.Books.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Book Added successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UpdateBook(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var book = _db.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBook(Book obj)
        {
            if (obj.BookName == obj.Id.ToString())
            {
                ModelState.AddModelError("name", "The Name and Id cannot be same.");
            }

            if (ModelState.IsValid)
            {
                _db.Books.Update(obj);
                _db.SaveChanges(true);
                TempData["success"] = "Data Updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var book = _db.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(int? id)
        {
            var obj = _db.Books.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Books.Remove(obj);
            _db.SaveChanges(true);
            TempData["success"] = "Book Deleted successfully";
            return RedirectToAction("Index");
            return View();
        }
    }
}
