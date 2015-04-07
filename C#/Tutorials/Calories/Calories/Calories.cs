using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calories
{
    class Calories
    {
        static void Main(string[] args)
        {
            double calories = 3.9, total = 0;

            for (int count = 1; count <= 30; count++){
                total = total + calories;
                if (count == 10 || count == 15 || count == 20 || count == 25 || count == 30){
                    Console.WriteLine("You have burned " + total + " Calories in " + count + " minutes!");

                }
               



            }
            Console.ReadLine();
        }
    }
}
