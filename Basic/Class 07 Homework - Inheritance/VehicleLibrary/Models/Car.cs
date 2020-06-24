using System;
using System.Collections.Generic;
using System.Text;
using VehicleLibrary.Enums;

namespace VehicleLibrary
{
    public class Car : WheeledVehicle
    {
        public EngineType Engine { get; set; }
        public double FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        

        public virtual void Drive()
        {
            Console.WriteLine($"{Manufacturer} {Model} is driving with {MaxSpeed}Kmh.");
        }
        public Car()
        {

        }
        public Car(int id, string manufacturer, string model, string type, EngineType engine, double fuelconsumption, int numberofdoors, int maxspeed)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Type = "Car";
            FuelConsumption = fuelconsumption;
            NumberOfDoors = numberofdoors;
            MaxSpeed = maxspeed;
            Engine = engine;
            
        }
        public override void Repair()
        {
            Console.WriteLine($"The vehicle {Manufacturer} {Model} is repaired, and the wheels are changed.");
        }

    }
}
