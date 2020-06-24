using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark...");
        }
        public static bool Validate(Dog dog)
        {
            if (dog.ID < 0 || dog.Name.Length < 2 || dog.Color == "") return false;
            return true;
        }
    }
}
