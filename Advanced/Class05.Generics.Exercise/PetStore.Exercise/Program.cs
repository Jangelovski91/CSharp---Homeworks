using Exercise.Generics.Models;
using System;

namespace PetStore.Exercise
{
    class Program
    {
        static PetStore<Dog> _dogStore = new PetStore<Dog>();
        static PetStore<Cat> _catStore = new PetStore<Cat>();
        static PetStore<Fish> _fishStore = new PetStore<Fish>();
        static void Main(string[] args)
        {
            _dogStore.Pets.Add(new Dog("Max", 2, true, "meat"));
            _dogStore.Pets.Add(new Dog("Jacky", 1, false, "dog food"));
            _catStore.Pets.Add(new Cat("Tom", 3, true, 8));
            _catStore.Pets.Add(new Cat("Garffild", 4, false, 9));
            _fishStore.Pets.Add(new Fish("Lucky", 1, "orange", "small-size"));
            _fishStore.Pets.Add(new Fish("Oly", 3, "blue", "middle-size"));

            Console.WriteLine("-----------All pets--------------");
            _dogStore.Printpets();
            _catStore.Printpets();
            _fishStore.Printpets();
            Console.WriteLine("----------------Shoping----------------------");
            
            _dogStore.BuyPat("Jacky");
            _catStore.BuyPat("Tom");
            _fishStore.BuyPat("Oly");
            Console.WriteLine("-----------------after shoping-----------------");
            _dogStore.Printpets();
            _catStore.Printpets();
            _fishStore.Printpets();

            Console.ReadLine();
        }
    }
}
