using AbstractFactoryPattern.Interfaces.ClassInterface;

namespace AbstractFactoryPattern.Vehicles
{
    public class Hyundai : IVehicle
    {
        public void CalculateAverage()
        {
            Console.WriteLine("Average for Hyundai");
        }
    }
}
