using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Methods
    {
        static void Main(string[] args)
        {
           int resultOfFuction = addTwoNumbers();

           Console.WriteLine(resultOfFuction);

           string message = getMessage();
           Console.WriteLine(message);
            //Or to save time
            //Console.WriteLine(getMessage());

           Console.ReadLine();

          
        }
        static int addTwoNumbers() 
        {
            int num1 = 13;
            int num2 = 7;
            int sum = num1 + num2;

            return sum;
        }

        static string getMessage()
        {
            return "Hello";
        }
       
    }
}
