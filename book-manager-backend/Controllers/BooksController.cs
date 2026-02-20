using book_manager_backend.Models;
using book_manager_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace book_manager_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {

        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var book = _bookService.GetById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            var created = _bookService.Add(book);

            if (created == null)
            {
                // 409 Conflict → resource already exists
                return Conflict(new { message = $"A book with ISBN {book.ISBN} already exists." });
            }

            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Book book)
        {
            var success = _bookService.Update(id, book);

            if (!success)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _bookService.Delete(id);

            if (!success)
                return NotFound();

            return NoContent();
        }


    }
}
