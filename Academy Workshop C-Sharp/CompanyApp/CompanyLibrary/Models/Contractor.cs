using CompanyLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsilbe { get; set; }

        public Contractor(string firstName, string lastName, Manager responsible, double workHours)
        {
            FirstName = firstName;
            LastName = LastName;
            Responsilbe = responsible;
            Role = RoleType.Contractor;
            workHours = WorkHours;
            PayPerHour = 21;
        }
        public Contractor()
        {

        }

        public override double GetSalary()
        {
            
            var sum = WorkHours * PayPerHour;
            return Salary += sum;
        }

    }
}
