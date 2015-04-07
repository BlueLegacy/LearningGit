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
            Console.WriteLine("How many days did you work?");
            int max = int.Parse(Console.ReadLine());
            int day = 1, pennies = 1,total=pennies ;

            Console.WriteLine("Day     Pennies     Total");

            while(day<=max){
                Console.WriteLine(day+"     "+pennies*.01+"     "+total*.01);
               pennies *= 2;
                total = total + pennies;
                day++;

                




            }
            Console.ReadLine();
        }
    }
}