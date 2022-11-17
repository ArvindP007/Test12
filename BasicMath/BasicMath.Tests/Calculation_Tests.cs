using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BasicMath.Tests
{
    public class Calculation_Tests
    {
        [Fact]
        public void Add_GivenTwoValues_ReturnsSuccess()
        {
            var calc = new Calculation();
            int a= calc.Add(1, 2);

            Assert.Equal(a,3);
        }
        [Fact]
        public void Fib_CheckInclude3_ReturnSuccess()
        {
            var calc = new Calculation();
            Assert.Contains(3, calc.FiboNumbers);
        }
        [Fact]
        public void Fib_CheckEqual_ReturnSuccess()
        {
            var collection = new List<int>() { 1, 2, 3 };
            var calc = new Calculation();
            Assert.Equal(collection, calc.FiboNumbers);
        }
        [Theory]
        [InlineData(1,true)]
        [InlineData(200,false)]
        public void IsOdd_TestOddAndEven(int val,bool expected)
        {
            var calc = new Calculation();
            var result = calc.IsOdd(val);
            Assert.True(expected);
        }
    }
}
