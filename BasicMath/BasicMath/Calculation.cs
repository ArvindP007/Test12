using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public List<int> FiboNumbers= new List<int>(){1, 1, 2, 3, 5, 8, 13};
        public bool IsOdd(int val)
        {
            return (val%2)==1;
        }

    }
}
