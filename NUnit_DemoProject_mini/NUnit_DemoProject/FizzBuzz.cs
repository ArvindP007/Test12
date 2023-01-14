using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_DemoProject
{
    public class FizzBuzz
    {
        public static string GetOutput(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "Fizzbuzz";
            else if (num % 3 == 0)
                return "Fizz";
            if (num % 5 == 0)
                return "Buzz";
            return num.ToString();
        }
    }
}
