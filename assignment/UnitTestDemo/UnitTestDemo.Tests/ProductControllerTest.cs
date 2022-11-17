using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo.Controllers;
using UnitTestDemo.Models;

namespace UnitTestDemo.Tests
{
    public class ProductControllerTest
    {
        [Fact]
        public void Test_Index_NotNull()
        {
            //Arrange
            var controller = new ProductController();
            var result = (controller.Index()) as ViewResult;
            //Action
            var productList = (List<Product>?)result?.ViewData.Model;
            //Assert
            Assert.NotNull(productList);
            Assert.Equal(3, productList?.Count);
        }
        [Fact]
        public void Test_Index_ReturnsViewName()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.Equal("Details", result?.ViewName);
        }
        [Fact]
        public void Test_Index_ReturnsViewData()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            var product = result?.ViewData.Model;
            Assert.NotNull(product);
            Assert.Equal("LCD", product?.ToString());
        }

        public void Test_IfIdLessThanOne_Returns_Details()
        {
            var controller = new ProductController();
            var result = (RedirectToActionResult)controller.Details(-1);
            Assert.Equal("Index", result.ActionName);
        }

    }
}
