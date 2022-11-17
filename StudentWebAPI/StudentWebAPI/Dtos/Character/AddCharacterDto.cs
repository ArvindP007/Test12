using StudentWebAPI.Models;

namespace StudentWebAPI.Dtos.Character
{
    public class AddCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Frodo";
        public string Description { get; set; }
        public int Strength { get; set; } = 1000;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
