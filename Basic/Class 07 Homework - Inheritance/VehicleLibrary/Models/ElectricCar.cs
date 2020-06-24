using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary.Models
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; }
        public double BaterryPercentage { get; set; }
      

        public void Recharge()
        {
            Console.WriteLine($"The {Manufacturer} {Model} is recharging at the moment!");
        }
        public ElectricCar()
        {

        }
        public ElectricCar(int id, string manufacturer, string model, string type, double fuelconsumption, int numberofdoors, int maxspeed)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Type = "Car";
            FuelConsumption = fuelconsumption;
            NumberOfDoors = numberofdoors;
            MaxSpeed = maxspeed;
            Engine = EngineType.electric;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Manufacturer} {Model} Car is driving with a max speed of {MaxSpeed}KmH.");

        }
    }

}
