using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CountDown
    {
        static void Main(string[] args)
        {

            int num = Convert.ToInt32(Console.ReadLine());
            countDown(num);
            Console.ReadLine();

        }

        public static void countDown(int num){
                    if (num <= 0 )
                        {
                            Console.WriteLine("Yay! You counted down");
                        }
                    else 
                    {
                        Console.WriteLine(num);
                            
                        countDown(num-1);
                    }


                }
    }
}
