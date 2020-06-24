using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static class DogShelter
    {
        public static List<Dog> DogList;
        static DogShelter()
        {
            DogList = new List<Dog>();
        }
        public static void PrintAll()
        {
            foreach( var dog in DogList)
            {
                Console.WriteLine(dog.Name);
            }
        }
    }
}
