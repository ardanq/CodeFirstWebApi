using System.ComponentModel.DataAnnotations;

namespace CodeFirstWebApi.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }


    }
}
