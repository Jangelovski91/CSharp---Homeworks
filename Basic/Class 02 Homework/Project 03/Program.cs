using System;

namespace Project_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number.");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            double b = int.Parse(Console.ReadLine());

            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine("First Number is-" + a);
            Console.WriteLine("Second NUmber is-" + b);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
