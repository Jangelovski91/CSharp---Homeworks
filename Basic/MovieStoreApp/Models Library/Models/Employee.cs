using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library.Models
{
    public class Employee : Member
    {
        private static int _iDGenerator = 0;
        private double Salary { get; set; }
        public double HoursPerMonth { get; set; }
        public double? Bonus { get; set; }


        public Employee()
        {
            Role = RoleType.Employee;
        }

        public Employee(string firstName, string lastName, string userName, string pass)
        {
            _iDGenerator++;
            Id = _iDGenerator;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = pass;
            Role = RoleType.Employee;

        }

        public Employee(string firstName, string lastName, int age, string userName,string pass, DateTime registrationDate, double hours)
            : base(firstName, lastName, age, userName, pass, registrationDate)
        {
            _iDGenerator++;
            Id = _iDGenerator;
            Role = RoleType.Employee;
            HoursPerMonth = hours;
        }
        
        
        public void SetBonus()
        {
            if(HoursPerMonth > 160)
            {
                Bonus =  0.3;
            }
            else
            {
                Bonus = null;
            }
        }
        public void SetSalary()
        {
            double bonus = Convert.ToDouble(Bonus);
            Salary = 300 + HoursPerMonth * bonus;
        }

    }
}
