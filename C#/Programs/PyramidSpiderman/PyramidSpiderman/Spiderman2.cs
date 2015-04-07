using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PyramidSpiderman
{
    class Spiderman2
    {
        static void Main(string[] args)
        {


            using (FileStream fs = new FileStream("In.txt", FileMode.Open)) 
            {
                using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
            }
                string value = Console.ReadLine();

            
                     for (int start = 1; start <= value.Length; start++) 
                         {
                            string substring = value.Substring(0, start);
                            Console.WriteLine(substring);
                          }
                Console.ReadLine();

        }
    }
}
