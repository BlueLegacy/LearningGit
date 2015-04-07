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

            int bugs;
            int bugsTotal = 0;

            for (int number = 1; number <= 7; number++)
            {
                Console.WriteLine("How many bugs today?");
                bugs = int.Parse(Console.ReadLine());
                bugsTotal = bugsTotal + bugs;
            }
            Console.WriteLine("You have collected " + bugsTotal + " bugs.");
            Console.ReadLine();
        }
    }
}
