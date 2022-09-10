using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Factory_Pattern_Exercise
{
    public class MotorCylce : IVehicle 
    {
        public MotorCylce()
        { 
        }

        public void Drive()
        {
            Console.WriteLine("The motorcycle is in drive.");
        }
    }
}
