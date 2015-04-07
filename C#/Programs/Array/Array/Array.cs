
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Array
    {
        static void Main(string[] args)
        {
            string[] values = new string[7];
            values[0] = Console.ReadLine();
            values[1] = values[0] * 2;
            values[2] = values[1] * 2;
            values[3] = values[2] * 2;
            values[4] = values[3] * 2;
            values[5] = values[4] * 2;

            foreach (string value in values)
            {
                Console.WriteLine(value);
                Console.ReadLine();
            }

        }
    }
}
