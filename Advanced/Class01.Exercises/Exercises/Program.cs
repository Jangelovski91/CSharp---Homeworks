using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Console.WriteLine("Enter random text here, If you want to stop pres X.");
            while (true)
            {

                string textRandom = Console.ReadLine();
                if (textRandom.ToLower() == "x")
                {
                    break;
                }

                words.Add(textRandom.ToLower());
              
            }
            Console.WriteLine("Now insert the text/word you are searching for in the text above.");
            string text = Console.ReadLine();
            var result = words.
                            Where(w => w.Contains(text.ToLower())).Count();
            Console.WriteLine($"Word - {text} in a text from above contains {result} time/s.");


            Console.ReadLine();
        }
    }
}



