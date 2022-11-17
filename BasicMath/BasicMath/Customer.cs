using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    public class Customer
    {
        public virtual int GetOrderByName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }
        public int age => 25;
    }
    public class LoyalCustomer : Customer
    {
        public int Discount { get; set; }
        public LoyalCustomer()
        {
            Discount = 10;
        }
        public override int GetOrderByName(string name)
        {
            return 101;
        }
    }
}
