using System;
class Program
{
    static void Main()
    {
        Vehicle myVehicle = new Vehicle();
        myVehicle.Start();
        Vehicle myCar = new Car();
        myCar.Start();
        Vehicle myBike = new Bike();
        myBike.Start();
    }
}
