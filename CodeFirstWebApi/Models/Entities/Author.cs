using System.ComponentModel.DataAnnotations;

namespace CodeFirstWebApi.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength (100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength (100)]
        public string LastName { get; set; }
        
        public virtual ICollection<Book> Books { get; set; }
    }
}
