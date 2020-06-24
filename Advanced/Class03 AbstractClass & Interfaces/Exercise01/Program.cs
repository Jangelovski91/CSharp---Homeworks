using System;
using System.Collections.Generic;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Max = new Student()
            {
                Id = 01,
                Name = "Max",
                UserName = "Maxi",
                Password = "max1234",
                Grades = new List<int>() { 3, 5, 2, 1, 4 }
            };
            Student John = new Student()
            {
                Id = 02,
                Name = "John",
                UserName = "Johny",
                Password = "john1234",
                Grades = new List<int>() { 2, 5, 3, 3, 3 }
            };
            Teacher Cole = new Teacher()
            {
                Id = 03,
                Name = "Cole",
                UserName = "TeacherC",
                Password = "cole123",
                Subjects = new List<string> { "Math", "Biology", "Physics" }
            };
            Teacher Ben = new Teacher()
            {
                Id = 04,
                Name = "Ben",
                UserName = "TeacherB",
                Password = "ben123",
                Subjects = new List<string> { "Sport", "Music", "Art" }
            };

            Max.PrintUser();
            John.PrintUser();
            Cole.PrintUser();
            Ben.PrintUser();

            Console.ReadLine();
        }
    }
}
