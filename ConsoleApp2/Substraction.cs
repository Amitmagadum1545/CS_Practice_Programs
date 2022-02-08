using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Substraction
    {
        public static void GetSubstraction()
        {
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int subOfTwo = num1 - num2;
            Console.WriteLine($"Substraction of {num1} and {num2} is {subOfTwo}");
            Console.ReadLine();
        }
    }
}
