using Library_WebAPI.Dtos;
using Library_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_WebAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
