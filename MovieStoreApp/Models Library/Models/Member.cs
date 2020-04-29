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
        public int Password { get; set; }
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

        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName}: {LastName}: ; Registered on: {DateOfRegistration}");
        }


    }
}
