using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {   
        static void WriteFile(string Filename)
        { 
            File.WriteAllText(Filename, "yo.txt");
        }

        static void ReadFile(string Filename) 
        { 
            Console.WriteLine(File.ReadAllText(Filename));
        }

        static void Main(string[] args)//main
        {

            string Filename = @"C:\test\yo.txt";
            WriteFile(Filename);
            ReadFile(Filename);
            Console.Read();












































        }
    }
}
