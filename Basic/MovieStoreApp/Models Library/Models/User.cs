using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library.Models
{
    public class User : Member
    {
        private static int _iDGenerator = 0;
        public int MemberNumber { get; set; }
        public SubscriptionType Subscription { get; set; }
        public List<Movie> Movies { get; set; }

        
        public User()
        {
            Role = RoleType.User;
        }
        public User(string firstName, string lastName, string userName, string pass)
        {
            _iDGenerator++;
            Id = _iDGenerator;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = pass;
            Role = RoleType.User;

        }

        public User(string firstName, string lastName, int age, string userName, string pass, DateTime registrationDate,int memberNumber,SubscriptionType subscription) 
            : base(firstName, lastName, age, userName, pass, registrationDate)
        {
            _iDGenerator++;
            Id = _iDGenerator;
            Role = RoleType.User;
            MemberNumber = memberNumber;
            Subscription = subscription;
        }
    }
}
