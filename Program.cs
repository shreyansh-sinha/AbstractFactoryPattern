using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Interfaces.ClassInterface;
using AbstractFactoryPattern.Interfaces.FactoryInterface;
public class Program
{
    public static void Main(String[] args)
    {
        VehicleFactory vehicleFactory = new();
        IFactoryType ordinaryFactory = vehicleFactory.GetVehicleFactoryType("Ordinary");
        IVehicle swift = ordinaryFactory.GetVehicle("Swift");
        swift.CalculateAverage();

        IFactoryType luxuryFactory = vehicleFactory.GetVehicleFactoryType("Luxury");
        IVehicle bmw = luxuryFactory.GetVehicle("BMW");
        bmw.CalculateAverage();
    }
}