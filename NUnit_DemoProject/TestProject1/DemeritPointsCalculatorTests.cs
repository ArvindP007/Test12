using NUnit_DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPointsTests_ReturnsZero()
        {
            var DemeritPoints = new DemeritPointsCalculator();
            var result = DemeritPoints.CalculateDemeritPoints(60);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPointsTests_ThrowsException()
        {
            var DemeritPoints = new DemeritPointsCalculator();

            Assert.That(() => DemeritPoints.CalculateDemeritPoints(-1),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPointsTests_ReturnsDemeritPoints()
        {
            var DemeritPoints = new DemeritPointsCalculator();
            var result = DemeritPoints.CalculateDemeritPoints(85);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
