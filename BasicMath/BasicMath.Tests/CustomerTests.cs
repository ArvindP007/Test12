using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckAgeForDiscount_ReturnSuccess()
        {
            var customer = new Customer();
            Assert.InRange(customer.age, 25, 30);
            //customer.GetOrderByName
        }
        [Fact]
        public void GetOrderName()
        {
            var customer = new Customer();
            var exceptionDetails=Assert.Throws<ArgumentException>(() => customer.GetOrderByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);
        }
        [Fact]
        [Trait("Category","LoyalCustomer")]
        public void GetOrderName_Loyal()
        {
            var loyalcustomer = new LoyalCustomer();
            Assert.Equal(101,loyalcustomer.GetOrderByName(""));

        }
    }
}
