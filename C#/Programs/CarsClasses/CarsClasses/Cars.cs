using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Cars
    {
        private string yearModel;
        private string Make;
        private int Speed;

        //accessors & mutators
        public void setYearModel(string newYearModel){
             model = newYearModel;
            }
                public string getYearModel()
                    {
                        return YearModel;
                    }

        public void setnewMake(string newMake){
             model = newMake;
            }
                 public string getMake()
                     {
                        return Make;
                     }

        public void setSpeed(int newSpeed){
             model = newSpeed;
            }
                 public int getSpeed()
                    {
                        return Speed;
                    }
    }
}
