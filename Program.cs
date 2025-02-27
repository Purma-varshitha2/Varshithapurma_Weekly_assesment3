using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter vehicle type (Car/Bike): ");
        string input = Console.ReadLine();

        try
        {
            IVehicle vehicle = VehicleFactory.GetVehicle(input);
            vehicle.Drive();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
