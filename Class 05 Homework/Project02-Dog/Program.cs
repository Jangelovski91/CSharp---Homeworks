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
            Dog Max = new Dog();
            Console.WriteLine("Enter dog's name.");
            Max.Name = Console.ReadLine();

            Console.WriteLine("Enter dog's race.");
            Max.Race = Console.ReadLine();

            Console.WriteLine("Enter dog's color.");
            Max.Color = Console.ReadLine();
            Console.WriteLine("Choose one of next dog's actions:Eat, Play, ChaseTail...");
            string DogsAction = Console.ReadLine();
            if(DogsAction == "Eat")
            {
                Max.Eat();
            } else if(DogsAction == "Play")
            {
                Max.Play();
            } else if(DogsAction == "ChaseTail")
            {
                Max.ChaseTail();
            } else
            {
                Console.WriteLine("Wrong Input!"); 
            }
            
            Console.ReadLine();
        }
    }
}
