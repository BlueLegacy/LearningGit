using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PhoneNumberGenerator
    {
        static void Main(string[] args)
        {
            string search;
            int found=0;
            Console.WriteLine("Please enter a name.");
            search = Console.ReadLine();
            string[] names = new string[7];
            
                 names[0] = "Jack";
                 names[1] = "Brock";
                 names[2] = "Trevor";
                 names[3] = "Emily";
                 names[4] = "Anthony";
                 names[5] = "Scott";
                 names[6] = "Zack";
            
            string[] phoneNumbers = new string[7];
                 phoneNumbers[0] = "517-458-8495";
                 phoneNumbers[1] = "517-658-7245";
                 phoneNumbers[2] = "517-384-5832";
                 phoneNumbers[3] = "517-754-2849";
                 phoneNumbers[4] = "517-335-9986";
                 phoneNumbers[5] = "517-778-6455";
                 phoneNumbers[6] = "517-774-3363";

                 for (int i = 0; i<names.Length;i++)
                 {
                     if (search == names[i]) 
                     {
                         Console.WriteLine(phoneNumbers[i]);
                         Console.ReadLine();
                         found++;
                     }

                 }
                 if (found == 0) {
                     Console.WriteLine("This person is not found.");
                     Console.ReadLine();
                 }

        }
    }
}
