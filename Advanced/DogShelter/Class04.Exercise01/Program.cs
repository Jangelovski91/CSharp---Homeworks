using Models;
using System;

namespace Class04.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Max = new Dog() { ID = 1, Name = "Max", Color = "black" };
            Dog Back = new Dog() { ID = 2, Name = "Back", Color = "brown" };
            Dog Lea = new Dog() { ID = 3, Name = "Lea", Color = "white" };

            DogShelter.DogList.Add(Max);
            DogShelter.DogList.Add(Back);
            DogShelter.DogList.Add(Lea);

            DogShelter.PrintAll();

            Console.ReadLine();
        }
    }
}
