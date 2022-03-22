namespace CodeFirstWebApi.Models.DTO_s
{
    public class CreateBookRequest
    {
        public string Title { get; set; }

        public int TotalPages { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

    }
}
