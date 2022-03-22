using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstWebApi.Models
{
    public class Book
    {
        public Book()
        {
            Authors = new HashSet<Author>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public int TotalPages { get; set; }

        [Required]
        [MaxLength(17)]
        public string Isbn { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        [DefaultValue("true")]
        public  bool Active { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}
