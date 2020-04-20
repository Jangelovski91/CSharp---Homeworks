using System;
using VehicleLibrary;
using VehicleLibrary.Enums;
using VehicleLibrary.Models;

namespace Inheritance_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Opel = new Car(123, "Opel", "Insignia", "Car", EngineType.diesel, 10, 5, 280);
            Opel.PrintInfo();
            Opel.Repair();
            Opel.Drive();

            Bicycle Giant = new Bicycle(3254, "Giant", "Fastroad", 7, false);
            Giant.PrintInfo();
            Giant.Repair();
            Giant.Ride();

            ElectricCar Tesla = new ElectricCar(321, "Tesla", "Model X", "car", 0, 3, 240);
            Tesla.PrintInfo();
            Tesla.Repair();
            Tesla.Recharge();
            Tesla.Drive();



            Console.ReadLine();
        }
    }
}
