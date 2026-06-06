using Librery.Interfaces;
using Librery.Models;
using Librery.Services;
using Microsoft.AspNetCore.Mvc;


namespace Librery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _bookServices;
        public BookController(IBook bookServices)
        {
            _bookServices = bookServices;
        }

        [HttpGet]
        public ActionResult<List<Book>> Get()
        {
            return _bookServices.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            return _bookServices.GetBookById(id);
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            if (book == null)
                return NotFound();
            _bookServices.Add(book);
            return Created();
        }

        [HttpDelete]
        public ActionResult Delete(Book book)
        {
            if (book == null)
                return NotFound();
            _bookServices.Delete(book);
            return Created();
        }
    }
}
