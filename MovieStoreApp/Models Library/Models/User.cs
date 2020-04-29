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

        }
        public User(string firstName,string lastName,int age,string userName,DateTime date,int idNumber,SubscriptionType subscription,Movie[] movie) 
            : base(RoleType.User)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            DateOfRegistration = date;
            MemberNumber = idNumber;
            Subscription = subscription;
            Movies = movie;
        }
    }
}
