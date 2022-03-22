using System.ComponentModel.DataAnnotations;


namespace CodeFirstWebApi.Models.Entities
{
    public class BookAuthor
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId{ get; set; }
    }
}
