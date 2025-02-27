using System;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(string vehicleType)
    {
        if (vehicleType.Equals("Car", StringComparison.OrdinalIgnoreCase))
        {
            return new Car();
        }
        else if (vehicleType.Equals("Bike", StringComparison.OrdinalIgnoreCase))
        {
            return new Bike();
        }
        else
        {
            throw new ArgumentException("Invalid vehicle type");
        }
    }
}

