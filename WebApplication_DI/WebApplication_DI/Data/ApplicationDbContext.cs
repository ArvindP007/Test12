using Microsoft.EntityFrameworkCore;
using WebApplication_DI.Models;

namespace WebApplication_DI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name="Abc", Email="abc@gmail.com"},
                new Student { Id = 2, Name = "xyz", Email = "xyz@gmail.com"}
                );
        }

    }
}
