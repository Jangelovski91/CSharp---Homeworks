using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library.Models
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public SubscriptionType Subscription { get; set; }
        public Movie[] Movies { get; set; }

        
        public User()
        {
            Role = RoleType.User;
        }
        public User(string firstName, string lastName, string userName, string pass)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = pass;
            Role = RoleType.User;

        }

        public User(string firstName, string lastName, int age, string userName, string pass, DateTime registrationDate,int memberNumber,SubscriptionType subscription) 
            : base(firstName, lastName, age, userName, pass, registrationDate)
        {
            Role = RoleType.User;
            MemberNumber = memberNumber;
            Subscription = subscription;
        }
    }
}
