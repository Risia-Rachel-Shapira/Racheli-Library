using Librery.Interfaces;
using Librery.Models;

namespace Librery.Services
{
    public class BookServices : IBook
    {
        private readonly DataContext _context;
        public BookServices(DataContext context)
        {
            _context = context;
        }
        public List<Book> Get()
        {
            return _context.books;
        }
        public Book GetBookById(int idBook)
        {
            return _context.books.FirstOrDefault(f => f.idBook == idBook);
        }
        public void Add(Book book)
        {
            _context.books.Add(book);
        }
        public void Delete(Book book)
        {
            _context.books.Remove(book);
        }
    }
}
