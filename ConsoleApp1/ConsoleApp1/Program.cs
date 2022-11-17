namespace ConsoleApp1
{
class Program
    {
        static void Main(string[] args)
        {
            Calc p = new Calc();
            p.primeNumber();
            p.swap();
        }
    }
class Calc
    {
        public int Value { get; set; }
        public void primeNumber()
        {
            Console.WriteLine("Enter the number to check prime");
            int value = Convert.ToInt32(Console.ReadLine());
            int j = value / 2;
            int flag=0;
            for(int i = 1; i < value; i++,j--)
            {
                if(j%i == 0)
                {
                    Console.WriteLine("Yes");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("No");
            }

        }
        public void swap()
        {
            Console.WriteLine("Hello, World!");
            int a = 0;
            int b = 1;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("After swapping");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    }
}

