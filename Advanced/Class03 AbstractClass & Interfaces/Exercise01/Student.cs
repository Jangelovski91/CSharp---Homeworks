using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }
        public void PringGrades()
        {
            foreach(int grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Studen {Name} with id number {Id}, this year finised with avearge grade of {Grades.Sum() / Grades.Count()}.");
        }
    }
}
