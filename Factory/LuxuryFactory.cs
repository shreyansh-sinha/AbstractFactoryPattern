using AbstractFactoryPattern.Interfaces.ClassInterface;
using AbstractFactoryPattern.Interfaces.FactoryInterface;
using AbstractFactoryPattern.Vehicles;

namespace AbstractFactoryPattern.Factory
{
    internal class LuxuryFactory : IFactoryType
    {
        public IVehicle GetVehicle(string carType)
        {
            switch (carType)
            {
                case "BMW":
                    return new BMW();
                case "Mercedez":
                    return new Mercedez();
                default:
                    return null;
            }
        }
    }
}