using NUnit_DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class Html_formatter_tests
    {
        [Test]
        public void FormatAsBold()
        {
            var formatter = new Html_formatter();
            var result = formatter.FormatAsBold("abc");
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

        }
    }
}
