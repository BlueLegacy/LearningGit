using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Lottery
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] lottery = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(lottery[i]=r.Next(0,10));

            }
            Console.ReadLine();
            

        }
    }
}
