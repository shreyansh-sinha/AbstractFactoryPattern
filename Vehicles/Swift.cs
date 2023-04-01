using AbstractFactoryPattern.Interfaces.ClassInterface;

namespace AbstractFactoryPattern.Vehicles
{
    public class Swift : IVehicle
    {
        public void CalculateAverage()
        {
            Console.WriteLine("Average for Swift");
        }
    }
}
