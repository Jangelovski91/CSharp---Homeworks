using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise01
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; }
        public void PrintSubjects()
        {
            foreach(string subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Teacher {Name} with id number {Id}, this year teaches {Subjects.Count()} subjects.");
        }
    }
}
