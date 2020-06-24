using Exercise.Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore.Exercise
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets;
        public PetStore()
        {
            Pets = new List<T>();
        }
        public void Printpets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void BuyPat(string name)
        {
            T findPet = Pets.Where(p => p.Name == name)
                           .FirstOrDefault();
            if (findPet == null)
            {
                Console.WriteLine("In our pet store is not pet with that name!");
            }
            else
            {
                Pets.Remove(findPet);
                Console.WriteLine($"Good luck, you just bought pet {findPet.Name}!");
            }
        }
    }
}
