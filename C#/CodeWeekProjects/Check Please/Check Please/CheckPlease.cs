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
            string userInput = Console.ReadLine();
            double totalCost = 0;

    while(userInput != "END")
    {
        double totalCost = 0;

            double COFFEE = 0.50;
            double SODA = 1.00;
            double MILKSHAKE = 2.13;
            double PANCAKES = 3.25;
            double WAFFLES = 3.92;
            double HAMBURGER = 4.01;
            double PASTA = 4.44;
            double HOTDOG = 2.98;
            double CHIPS = 0.65;
            double FRIES = 0.99;
    
       if(userInput == "COFFEE" )
            {
                totalCost = totalCost + COFFEE;
            }
       
       if (userInput == "SODA") 
            {
                totalCost = totalCost + SODA;
            }

       if (userInput == "MILKSHAKE")
            {
                totalCost = totalCost + MILKSHAKE;
            }


       if (userInput == "PANCAKES")
            {
                totalCost = totalCost + PANCAKES;
            }

       if (userInput == "WAFFLES")
            {
                totalCost = totalCost + WAFFLES;
            }

       if (userInput == "HAMBURGER")
            {
                totalCost = totalCost + HAMBURGER;

            }

       if (userInput == "PASTA")
            {
                totalCost = totalCost + PASTA;
            }

       if (userInput == "HOTDOG")
            {
                totalCost = totalCost + HOTDOG;
            }

       if (userInput == "CHIPS")
            {
                totalCost = totalCost + CHIPS;
            }

       if (userInput == "FRIES")
            {
                totalCost = totalCost + FRIES;
            }
       double total = totalCost;
       return total;
      
    
            
    }


    Console.WriteLine("Your Total is: $" + totalCost);
        Console.ReadLine();
            
          
        }
    }
}
