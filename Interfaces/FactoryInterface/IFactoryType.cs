using AbstractFactoryPattern.Interfaces.ClassInterface;

namespace AbstractFactoryPattern.Interfaces.FactoryInterface
{
    public interface IFactoryType
    {
        public IVehicle GetVehicle(string carType);
    }
}
