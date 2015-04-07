using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SalesTax
    {
        static void Main(string[] args)
        {
            double salesTax=0;
            double total;
            double actualTotal;
            double cost = 0;

           string userInput = null;

           //userInput = Console.ReadLine();

           Console.WriteLine("What is your sales tax?");
           salesTax = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("What is the cost of your item?");
           cost = Convert.ToDouble(Console.ReadLine());

           salesTax = salesTax / 100;
           total = salesTax * cost;
           actualTotal = total + cost;

           Console.WriteLine("Your sales tax is $" + total);
           Console.WriteLine("Your total cost is $" + actualTotal);
           Console.ReadLine();
            

                


        }
    }
}
