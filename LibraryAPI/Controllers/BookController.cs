using LibraryAPI.Data;
using LibraryAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("library/api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("/library/api/books")]
        public ActionResult<List<Book>> Get()
        {
            return bookRepository.GetAll();
        }

        [HttpGet]
        [Route("/library/api/books/{id}")]
        public Book GetById(int id)
        {
            return bookRepository.GetById(id);
        }

        [HttpPost]
        [Route("/library/api/books")]
        public Book Add(Book book)
        {
            return bookRepository.Add(book);
        }

        [HttpPatch]
        [Route("/library/api/books/{id}")]
        public Book Update(Book book)
        {
            return bookRepository.Update(book);
        }

        [HttpDelete]
        [Route("/library/api/books/{id}")]
        public void Delete(int id)
        {
            bookRepository.Delete(id);
        }
    }
}
