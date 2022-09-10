using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Factory_Pattern_Exercise
{
    internal class AllElse : IVehicle
    {
        public AllElse() { }
        public void Drive()
        {
            Console.WriteLine("Unsure about that type of vehicle. What is it?");
        }
    }
}
