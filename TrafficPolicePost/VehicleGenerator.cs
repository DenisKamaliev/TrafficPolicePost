using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPolicePost
{
    public static class VehicleGenerator
    {
        public static Vehicle GenerateVehicle()
        {
            Random random = new Random();
            Vehicle vehicle = new Vehicle();
            int x = random.Next(3);
            if (x == 0)
                vehicle = GenerateCar();
            else if (x == 1)
                vehicle = GenerateBus();
            else if (x == 2)
                vehicle = GenerateTruck();
            return vehicle;


        }
        public static Vehicle GenerateCar()
        {
            Vehicle car = new Car();
            Random random = new Random();
            car.SetColor((Car.VehicleColor)new Random().Next(Enum.GetNames(typeof(Car.VehicleColor)).Length));
            car.SetBodyType(Vehicle.BodyType.Car);
            car.SetLicensePlateNumber(random.Next(100, 1000));
            car.SetHasPassenger(random.Next(2) == 1 ? true : false);
            return car;
        }
        public static Vehicle GenerateBus()
        {
            Vehicle Bus = new Bus();
            Random random = new Random();
            Bus.SetColor((Bus.VehicleColor)new Random().Next(Enum.GetNames(typeof(Bus.VehicleColor)).Length));
            Bus.SetBodyType(Vehicle.BodyType.Bus);
            Bus.SetLicensePlateNumber(random.Next(100, 1000));
            Bus.SetHasPassenger(random.Next(2) == 1 ? true : false);
            return Bus;
        }
        public static Vehicle GenerateTruck()
        {
            Vehicle Truck = new Truck();
            Random random = new Random();
            Truck.SetColor((Truck.VehicleColor)new Random().Next(Enum.GetNames(typeof(Truck.VehicleColor)).Length));
            Truck.SetBodyType(Vehicle.BodyType.Truck);
            Truck.SetLicensePlateNumber(random.Next(100, 1000));
            Truck.SetHasPassenger(random.Next(2) == 1 ? true : false);
            return Truck;
        }
    }
}
