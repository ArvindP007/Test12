namespace Library_WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? BookName { get; set; }

        public string? Author { get; set; }
        public int Price { get; set; }
    }
}
