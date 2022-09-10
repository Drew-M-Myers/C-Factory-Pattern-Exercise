using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Factory_Pattern_Exercise
{
    public class Truck : IVehicle
    {
        public Truck()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The truck is in drive.");
        }
    }
}
