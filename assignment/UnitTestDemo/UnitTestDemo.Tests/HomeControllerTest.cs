using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Controllers;
using UnitTestDemo.Models;

namespace UnitTestDemo.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Test_Index_ReturnsViewName()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            //ShouldThrowException();
            Assert.Equal("Index", result?.ViewName);
        }
        [Fact]
        public void Test_Index_ReturnsViewData()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            var product = (Product?)result?.ViewData.Model;
            Assert.Null(product);
        }
    }
}
