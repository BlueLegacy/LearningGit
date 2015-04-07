using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SingleParameter
    {
        static void Main(string[] args)
        {
            int aNumb;          
            Console.WriteLine("Please enter a number.");
            aNumb = int.Parse(Console.ReadLine());

            if (aNumb == 7)
                Console.WriteLine("My favorite number is 7!");
            else
                Console.WriteLine("My favorite number is not " + aNumb);
            Console.ReadLine();

        }
        static int Number(int num)
        {
            int total = num;
            num = 7;
            
            return total;
            

        }
    }
}
