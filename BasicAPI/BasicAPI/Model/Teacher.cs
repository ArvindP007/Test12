namespace BasicAPI.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<Student>? students { get; set; }
    }
}
