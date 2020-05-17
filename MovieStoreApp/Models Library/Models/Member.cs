using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public RoleType Role { get; set; }
        public Member()
        {

        }

        public Member(RoleType role)
        {
            Role = role;
        }

        public Member(string firstName, string lastName, int age, string userName, string pass, DateTime registrationDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = pass;
            DateOfRegistration = registrationDate;

        }

        public string GreetPerson()
        {
            return $"Hello {FirstName} {LastName} welcome in our movie world!";
        }

        public string DisplayInfo()
        {
            
                return
                    $"Member {FirstName} {LastName}, registered on  - {DateOfRegistration}.";
           
        }


    }
}
