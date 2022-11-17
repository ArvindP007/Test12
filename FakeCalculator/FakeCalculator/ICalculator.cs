using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCalculator
{
    public interface ICalculator
    {
        decimal Add(decimal num1, decimal num2);
        decimal Substract(decimal num1, decimal num2);
        decimal Multiply(decimal num1, decimal num2);
        decimal Divide(decimal num1, decimal num2);
    }
}
