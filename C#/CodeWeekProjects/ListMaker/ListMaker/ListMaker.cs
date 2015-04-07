using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace ConsoleApplication1
{
    class ListMaker
    {
        static void Main(string[] args)
        {
            string input;
            
            ArrayList list = new ArrayList();
            string[] inputArray;




            do{

                input = Console.ReadLine();
                string[] sep = {" "};
                inputArray = input.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                if (inputArray[0].Equals("ADD"))
                {
                    list.Add(inputArray[1]);
            }
                else if (inputArray[0].Equals("INSERT"))
            {
                int tempIndex = list.IndexOf(inputArray[2]);
                list.Insert(tempIndex, inputArray[1]);
            }
                else if (inputArray[0].Equals("REMOVE"))
                {
                    list.Remove(inputArray[1]);
            }
                

            } while (!inputArray[0].Equals("SHOW"));

            foreach (string i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
           
        }
    }
}
