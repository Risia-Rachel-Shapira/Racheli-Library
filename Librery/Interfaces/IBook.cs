using Librery.Models;
using Librery.Services;
using Microsoft.AspNetCore.Mvc;

namespace Librery.Interfaces
{
    public interface IBook
    {
        List<Book> Get();
        Book GetBookById(int id);
        void Add(Book book);
        void Delete(Book book);
    }
}
