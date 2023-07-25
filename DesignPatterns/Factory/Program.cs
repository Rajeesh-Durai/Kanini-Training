using Factory;

internal class Vehicles
{
    
    public static void Main(string[] args)
    {
        VehicleFactory carfactory = new CarFactory();
        VehicleFactory bikefactory = new BikeFactory();
        Vehicle car = carfactory.CreateVehicle();
        Vehicle bike = bikefactory.CreateVehicle();
  
    }
}