using AbstractFactoryPattern.Interfaces.ClassInterface;
using AbstractFactoryPattern.Interfaces.FactoryInterface;
using AbstractFactoryPattern.Vehicles;

namespace AbstractFactoryPattern.Factory
{
    internal class OrdinaryFactory : IFactoryType
    {
        public IVehicle? GetVehicle(string carType)
        {
            switch (carType)
            {
                case "Swift":
                    return new Swift();
                case "Hyundai":
                    return new Hyundai();
                default:
                    return null;
            }
        }
    }
}