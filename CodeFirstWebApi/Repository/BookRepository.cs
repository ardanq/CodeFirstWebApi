using CodeFirstWebApi.Models;
using CodeFirstWebApi.Models.Entities;
using System.Linq;

namespace CodeFirstWebApi.Repository
{
    public class BookRepository:IBookRepository
    {
        private ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Book GetById(int Id)
        {
            var data = _context.Books.Where(x => x.Id == Id).FirstOrDefault();
            return data;
        }

        public void CreateBook(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }

        public void DeleteById(int Id)
        {
            var data = _context.Books.Where(x => x.Id == Id).FirstOrDefault();
            _context.Remove(data);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            var result = _context.Books.FirstOrDefault(x => x.Id == book.Id);
            result.Title = book.Title;
            result.TotalPages = book.TotalPages;
            result.Isbn = book.Isbn;
            result.Price = book.Price;
            result.Active = book.Active;
            _context.SaveChanges();
        }

    }
}
