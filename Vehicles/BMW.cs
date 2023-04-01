using AbstractFactoryPattern.Interfaces.ClassInterface;

namespace AbstractFactoryPattern.Vehicles
{
    public class BMW : IVehicle
    {
        public void CalculateAverage()
        {
            Console.WriteLine("Average for BMW");
        }
    }
}
