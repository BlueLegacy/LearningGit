using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace ConsoleApplication1
{
    class SystemIOTest
    {
        static void Main(string[] args)
        {
            String line = "";
            FileStream fsOut = new FileStream("Out.txt", FileMode.Create);
            StreamWriter w = new StreamWriter(fsOut, Encoding.UTF8);


            w.WriteLine("*********************");
            w.WriteLine("*                   *");
            using (FileStream fs = new FileStream("In.txt", FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                    {
                        
                        while((line=r.ReadLine())!=null){


                            
                            //do math here
                            int spaceAmount = (19 - line.Length) / 2;

                            w.Write("*");
                            //left spaces
                            for (int i = 0; i < spaceAmount; i++) 
                            {
                                w.Write(" ");
                            }

                            w.Write(line);
                            //right spaces
                            if(line.Length % 2==0)
                            {
                                w.Write(" ");
                            }

                            for (int i = 0; i < spaceAmount; i++)
                            {
                                w.Write(" ");
                            }

                            w.WriteLine("*");

                        }
                    }
                
                }
            w.WriteLine("*                   *");
            w.WriteLine("*********************");
            w.Flush();
            w.Close();

            Console.ReadLine();


        }
    }
}
