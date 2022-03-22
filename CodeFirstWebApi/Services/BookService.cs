using CodeFirstWebApi.Models;
using CodeFirstWebApi.Models.DTO_s;
using CodeFirstWebApi.Repository;

namespace CodeFirstWebApi.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void CreateBook(CreateBookRequest request)
        {
            Book book = new();
            
            book.Title = request.Title;
            book.Isbn = request.Isbn;
            book.Price = request.Price;
            book.TotalPages = request.TotalPages;

            _bookRepository.CreateBook(book);

        }

        public void DeleteById(int Id)
        {
           _bookRepository.DeleteById(Id);
        }

        public GetBookResponse GetById(int Id)
        {
            var data = _bookRepository.GetById(Id);

            GetBookResponse getBookResponse = new();

            getBookResponse.Id = data.Id;
            getBookResponse.Isbn = data.Isbn;
            getBookResponse.Price = data.Price;
            getBookResponse.Title = data.Title;
            getBookResponse.TotalPages = data.TotalPages;
            getBookResponse.Active = data.Active;
            
            return getBookResponse;

        }

        public void UpdateBook(UpdateBookRequest request)
        {
            Book book = new();

            book.Id = request.Id;
            book.Active = request.Active;
            book.Title = request.Title;
            book.Isbn = request.Isbn;
            book.Price = request.Price;
            book.TotalPages = request.TotalPages;

            _bookRepository.UpdateBook(book);
        }
    }
}
