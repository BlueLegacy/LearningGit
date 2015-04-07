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
            Console.WriteLine("Enter a positive number. Enter a negitive to cancel.");
            int end = 0,total=0, num;
            do{
                num = int.Parse(Console.ReadLine());
                
                total = total+num;
                if (num < 0) { total = total - num; }
            
            }while(num>0);
            Console.WriteLine("Total: "+total);
            Console.ReadLine();
        }
    }
}
