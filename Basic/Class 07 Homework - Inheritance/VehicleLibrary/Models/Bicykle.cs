using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary.Models
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        public bool IsElectric { get; set; }
        public void Ride()
        {
            Console.WriteLine($"Bicycle {Manufacturer} {Model} is riding.");
        }
        public Bicycle()
        {

        }
        public Bicycle(int id, string manufacturer, string model, int numberofspeedlevels, bool iselectric)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Type = "Bicycle";
            NumberOfSpeedLevels = numberofspeedlevels;
            IsElectric = iselectric;
          
        }
        public override void Repair()
        {
            Console.WriteLine($"Bicycle {Manufacturer} {Model} is repaired, and every element is checked.");
        }

    }
}
