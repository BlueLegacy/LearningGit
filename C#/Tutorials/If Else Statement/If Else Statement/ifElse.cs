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

            int number;

            Console.WriteLine("Please enter a number between 1 and 10:");
            number = int.Parse(Console.ReadLine());

            if (number > 10)
                Console.WriteLine("Hey! the number sould be 10 or less!");
            else
                if (number < 0)
                    Console.WriteLine("Hey! the number should be 0 or more!");
                else
                    Console.WriteLine("Good Job!");

            Console.ReadLine();
        }
    }
}
