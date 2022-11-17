using FakeCalculator;
using Moq;
using Xunit;

namespace FakeCalulator.tests
{
    public class CalculatorTests
    {
        [Fact]
        public void PassingTests()
        {
            //var calulator = new ICalculator();
            //Assert.Equal(4, calculator.Add(2, 2));

            // Fake
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(5);
            Assert.Equal(5, calculator.Object.Add(2, 2));
        }

        [Fact]
        public void AddTest()
        {
            var calculator = new Calculator();
            Assert.Equal(5, calculator.Add(2, 3));
        }
    }
}