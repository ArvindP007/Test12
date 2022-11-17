namespace Library_WebAPI.Dtos
{
    public class UpdateBookDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}
