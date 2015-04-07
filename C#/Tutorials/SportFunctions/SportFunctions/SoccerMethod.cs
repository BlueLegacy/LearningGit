using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SoccerMethod
    {
        static void Main(string[] args)
        {
            int socTot;
            int ca, cb, cc;
            Console.WriteLine("How many tickets were sold for Soccer Class A?");
            ca = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tickets were sold for Soccer Class B?");
            cb = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tickets were sold for Soccer Class C?");
            cc = int.Parse(Console.ReadLine());
            socTot = soccer(ca,cb,cc);
            Console.WriteLine("Your total is " + socTot);
            Console.ReadLine();

            int footTot;
            int fa, fb, fc;
            Console.WriteLine("How many tickets were sold for Football Class A?");
            fa = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tickets were sold for Football Class B?");
            fb = int.Parse(Console.ReadLine());
            Console.WriteLine("How many tickets were sold for Football Class C?");
            fc = int.Parse(Console.ReadLine());
            footTot = football(fa, fb, fc);
            Console.WriteLine("Your total is " + footTot);

            Console.ReadLine();

        }
        static int soccer(int tickA, int tickB, int tickC)
        { 
            int total = 0;
            total += tickA * 10;
            total += tickB * 8;
            total += tickC * 6;


            return total;
        }



        static int football(int tickA, int tickB, int tickC)
        { 
        
            int total = 0;
            total += tickA * 15;
            total += tickB * 12;
            total += tickC * 9;


            return total;
        }
    }
}
