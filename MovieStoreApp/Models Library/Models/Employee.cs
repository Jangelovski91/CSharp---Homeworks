using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library.Models
{
    public class Employee : Member
    {
        private double Salary { get; set; }
        public double HoursPerMonth { get; set; }
        public double? Bonus { get; set; }
        public Employee()
        {

        }
        public Employee(string firstName, string lastName, int age, string userName, DateTime date, double hours) : base(RoleType.Employee)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            DateOfRegistration = date;
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
