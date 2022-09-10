using C_Sharp_Factory_Pattern_Exercise;

namespace CSharpFactoryPatternExercise
{ 
    class program
    {
        static void Main(string[] args)
        {
            int userAnswer;
            bool input = false;

            do
            {
                Console.WriteLine("How many tires do you want your vehicle have?");

                input = int.TryParse(Console.ReadLine(), out userAnswer);

            } while (!input);

            var vehicle = VehicleFactory.GetVehicle(userAnswer);
            vehicle.Drive();
        }
    }
}