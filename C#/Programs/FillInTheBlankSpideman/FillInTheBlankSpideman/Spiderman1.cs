using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FillInTheBlankSpideman
{
    class Spiderman1
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string phrase = "FZGH";
            s1 = s1.Replace("FZGH", s2);
            Console.WriteLine(s1);
            Console.ReadLine();

            


        }
    }
}
