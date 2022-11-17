using Library_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WebAPI.Tests.MockData
{
    public class MockBookData
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>{
             new Book{
                 Id = 1,
                 BookName = "Why Shopping",
                 Author = "Me",
                 Price = 120
             },
             new Book{
                 Id = 2,
                 BookName = "Shopping expert",
                 Author = "Always-ME",
                 Price = 580
             },
             new Book{
                 Id = 3,
                 BookName = "Play Games",
                 Author = "Not-Me",
                 Price = 320
             }
         };
        }
        public static List<Book> GetEmptyBooks()
        {
            return new List<Book>();
        }
        public static Book NewBook()
        {
            return new Book
            {
                Id = 0,
                BookName = "wash cloths",
                Author = "Not-Me",
                Price = 1460
            };
        }
    }
}
