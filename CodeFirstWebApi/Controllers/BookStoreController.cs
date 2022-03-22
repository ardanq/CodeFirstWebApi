using CodeFirstWebApi.Models.DTO_s;
using CodeFirstWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookStoreController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{Id}")]
        public GetBookResponse GetById(int Id)
        {
            var data = _bookService.GetById(Id);
            return data;
        }

        [HttpPost]
        public void AddBook(CreateBookRequest book)
        {
            _bookService.CreateBook(book);
        }

        [HttpPut]
        public void UpdateBook(UpdateBookRequest book)
        {
            _bookService.UpdateBook(book);
        }

        [HttpDelete]
        public void DeleteBook(int Id)
        {
            _bookService.DeleteById(Id);
        }



    }
}
