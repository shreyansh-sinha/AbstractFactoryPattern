using AbstractFactoryPattern.Interfaces.ClassInterface;

namespace AbstractFactoryPattern.Vehicles
{
    public class Mercedez : IVehicle
    {
        public void CalculateAverage()
        {
            Console.WriteLine("Average for Mercedez");
        }
    }
}
