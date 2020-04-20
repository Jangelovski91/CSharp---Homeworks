using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Type { get; set; }
        public virtual void Repair()
        {
            Console.WriteLine($"The vehicle {Manufacturer} {Model} is repaired.");
        }
        public WheeledVehicle()
        {

        }
    }
}
