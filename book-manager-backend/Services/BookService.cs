using book_manager_backend.Models;
using System.Xml.Linq;

namespace book_manager_backend.Services
{
    public class BookService
    {

        private readonly List<Book> _books = new();

        public List<Book> GetAll()
        {
            return _books;
        }

        public Book? GetById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public Book Add(Book book)
        {

            // Check for duplicate ISBN
            if (_books.Any(b => b.ISBN == book.ISBN))
            {
                // Return null to indicate duplicate
                return null;
            }

            book.Id = _books.Count == 0 ? 1 : _books.Max(b => b.Id) + 1;
            _books.Add(book);
            return book;
        }

        public bool Update(int id, Book updatedBook)
        {
            var book = GetById(id);

            if (book == null)
                return false;

            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.ISBN = updatedBook.ISBN;
            book.PublicationDate = updatedBook.PublicationDate;

            return true;
        }

        public bool Delete(int id)
        {
            var book = GetById(id);

            if (book == null)
                return false;

            _books.Remove(book);
            return true;
        }

    }
}
