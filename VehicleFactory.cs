using System;
namespace C_Sharp_Factory_Pattern_Exercise
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int NumberOfTires)
        {
            switch (NumberOfTires)
            {
                case 4:
                    return new Truck();
                case 2:
                    return new MotorCylce();
                default:
                    return new AllElse();
            }
        }
    }
}