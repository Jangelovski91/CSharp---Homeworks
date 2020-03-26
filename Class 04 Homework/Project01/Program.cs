using System;

namespace Project01
{
    class Program
    {   

        static void Main(string[] args)
        {


           Substrings();
            Console.ReadLine();

        }
        static void Substrings()
        {

            string hello = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine(hello);
            Console.WriteLine($"Please enter a number n. from 1 to {hello.Length} ");
            int N = int.Parse(Console.ReadLine());
            if (N < 1 || N > hello.Length)
            {
                Console.WriteLine("Wrong number!");
            }
            else
            {
                string substring1 = hello.Substring(0, N);
                Console.WriteLine($@"The first {N} characters are ""{substring1}"" and the length of this substring is {substring1.Length}...");
            }


}
        
    }
}
