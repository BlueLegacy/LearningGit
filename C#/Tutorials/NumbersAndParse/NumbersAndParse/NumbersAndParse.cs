using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;

            Console.WriteLine("Please enter a number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank You, one more:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Adding the two numbers: " + (num1 + num2));

            Console.ReadLine();

        }
    }
}
