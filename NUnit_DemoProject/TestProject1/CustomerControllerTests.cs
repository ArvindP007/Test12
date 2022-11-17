using NUnit_DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void getCustomerTests()
        {
            var controller = new CustomerController();
            var result = controller.getCustomers(0);
            Assert.That(result,Is.TypeOf<NotFound>());

            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
    }
}
