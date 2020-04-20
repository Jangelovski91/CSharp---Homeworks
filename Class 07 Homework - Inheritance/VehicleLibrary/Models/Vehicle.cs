using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"This is {Manufacturer} {Model} with id- {Id}.");
        }

        public Vehicle()
        {

        }
        public Vehicle(int id, string manufacturer, string model)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
        }
}
}
