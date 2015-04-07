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
            Console.WriteLine("Enter two numbers");
            int toPass1 = Convert.ToInt32(Console.ReadLine());
            int toPass2 = Convert.ToInt32(Console.ReadLine());

            int result = addTwoNum(toPass1, toPass2);
            Console.WriteLine("The result of " +toPass1+ " and " +toPass2+ " is " +result);


            Console.ReadLine();
        }
        static int addTwoNum(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }
    }
}
