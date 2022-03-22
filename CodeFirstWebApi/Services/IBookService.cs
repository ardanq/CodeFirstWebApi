using CodeFirstWebApi.Models;
using CodeFirstWebApi.Models.DTO_s;

namespace CodeFirstWebApi.Services
{
    public interface IBookService
    {
        void CreateBook(CreateBookRequest request);

        GetBookResponse GetById(int Id);

        void DeleteById(int Id);

        void UpdateBook(UpdateBookRequest request);
    }
}
