using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit_DemoProject;
using NUnit.Framework;

namespace NUnit_DemoProject.Tests
{
    [TestFixture]
    public class HtmlFormatter_Tests
    {
        [Test]
        public void FormatAsBold_returnsStringWithStrongElement()
        {
            var formatter = new Html_formatter();
            var result = formatter.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("ABC"));
        }
    }
}
