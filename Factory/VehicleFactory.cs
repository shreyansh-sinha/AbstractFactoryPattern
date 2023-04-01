using AbstractFactoryPattern.Interfaces.FactoryInterface;

namespace AbstractFactoryPattern.Factory
{
    public class VehicleFactory
    {
        public IFactoryType? GetVehicleFactoryType(string factoryType)
        {
            switch (factoryType)
            {
                case "Ordinary":
                    return new OrdinaryFactory();
                case "Luxury":
                    return new LuxuryFactory();
                default:
                    return null;
            }
        }
    }
}
