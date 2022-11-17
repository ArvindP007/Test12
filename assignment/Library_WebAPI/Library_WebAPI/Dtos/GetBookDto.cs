using Library_WebAPI.Models;
namespace Library_WebAPI.Dtos
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
