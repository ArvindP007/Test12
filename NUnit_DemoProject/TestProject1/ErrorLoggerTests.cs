using NUnit_DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void logTest()
        {
            var logger = new ErrorLogger();
            logger.log("a");
            Assert.That(logger.LastError,Is.EqualTo("a"));
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowExceptionNullException(string error)
        {
            var logger = new ErrorLogger();
            Assert.That(() =>logger.log(error),Throws.ArgumentNullException);
        }
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            logger.log("a");

            var id = Guid.Empty;
            logger.ErrorLog += (sender, args) => { id = args; };

            Assert.That(id, Is.EqualTo(Guid.Empty));
        }
    }
}
