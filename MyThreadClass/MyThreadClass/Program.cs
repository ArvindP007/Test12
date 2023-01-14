using System;
using System.Threading;
namespace Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "First Thread";
            Console.WriteLine("Thread Name : {0}", t.Name);
            Console.WriteLine("Thread Priority : {0}", t.Priority);
            Console.WriteLine("Child Thread Paused...");
            // using Sleep() method
            Thread.Sleep(2000);
            Console.WriteLine("Child Thread Resumed...");
            Console.ReadKey();
        }
    }
}