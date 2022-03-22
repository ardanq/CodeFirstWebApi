namespace CodeFirstWebApi.Models.DTO_s
{
    public class GetBookResponse
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public int TotalPages { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }

        public bool Active { get; set; }


    }
}
