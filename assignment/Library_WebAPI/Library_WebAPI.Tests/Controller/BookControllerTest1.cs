using FakeItEasy;
using Library_WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WebAPI.Tests.Controller
{
    
    public class BookControllerTest1
    {
        private readonly IBookService _bookService;
        public BookControllerTest1()
        {
            _bookService = A.Fake<IBookService>();
        }
    }
}
