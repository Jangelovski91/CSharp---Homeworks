using System;

namespace Project02_Dog
{   
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is now eating.");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} is now playing!");
        }

        public void ChaseTail()
        {
            Console.WriteLine("The dog now is chasing its tail! :D");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog();
            Console.WriteLine("Enter dog's name.");
            max.Name = Console.ReadLine();

            Console.WriteLine("Enter dog's race.");
            max.Race = Console.ReadLine();

            Console.WriteLine("Enter dog's color.");
            max.Color = Console.ReadLine();
            Console.WriteLine("Choose one of next dog's actions:Eat, Play, ChaseTail...");
            string DogsAction = Console.ReadLine();
            if(DogsAction == "Eat")
            {
                max.Eat();
            } else if(DogsAction == "Play")
            {
                max.Play();
            } else if(DogsAction == "ChaseTail")
            {
                max.ChaseTail();
            } else
            {
                Console.WriteLine("Wrong Input!"); 
            }
            
            Console.ReadLine();
        }
    }
}
