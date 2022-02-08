using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Addition
    {
        public static void GetAddition()
        {
            Console.WriteLine("Welcome To Addition Program");
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"Addition of {a} and {b} is {c}");
            Console.ReadLine();
        }
    }
}
