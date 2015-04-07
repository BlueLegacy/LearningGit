using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Main
    {
        static void Main(string[] args)
        {
            Main camaro = new Main();
            camaro.setYearModel("1992");
            camaro.setMake("Camaro RS");
            camaro.setSpeed(85);

            Console.WriteLine(camaro.getYearModel()+" "+camaro.getMake());
            Console.WriteLine("The speed for this vehicle is "+camaro.getSpeed());


        }
    }
}
