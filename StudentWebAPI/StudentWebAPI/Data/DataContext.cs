using Microsoft.EntityFrameworkCore;
using StudentWebAPI.Models;

namespace StudentWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters {get; set;}
        public DbSet<User> Users { get; set; }
    }
}
