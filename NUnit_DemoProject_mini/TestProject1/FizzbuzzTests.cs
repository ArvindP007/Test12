using NUnit_DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class FizzbuzzTests
    {
        [Test]
        public void GetOutput_InputDivisibleBy3And5_ReturnsFizzbuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("Fizzbuzz"));
        }
        [Test]
        public void GetOutput_InputDivisibleBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(9);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutput_InputDivisibleBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(25);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void GetOutput_InputNotDivisibleBy3And5_ReturnsNum()
        {
            var result = FizzBuzz.GetOutput(2);
            Assert.That(result, Is.EqualTo("2"));
        }
    }
}
