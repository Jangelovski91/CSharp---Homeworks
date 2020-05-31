using Models_Library.Enums;
using Models_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStoreApp.Services
{
    public class UserService
    {

        private MovieService _movieService = new MovieService();
        private HelperService _helperService = new HelperService();
        public List<User> Users { get; set; }
        public UserService()
        {
            Users = new List<User>
            {

                new User()
                {
                    FirstName = "Nina",
                    LastName = "Panina",
                    Age = 19,
                    UserName = "nina_panina",
                    Password = "nina123",
                    DateOfRegistration = new DateTime(2019, 10, 10),
                    MemberNumber = 213,
                    Subscription = SubscriptionType.Annually
                },
                new User("Bob", "Bobsky", 29, "bob_bobsky","bob123", new DateTime(2015,11,01), 212, SubscriptionType.ThreeMonths),

            };
        }
        public User LogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return user;

                }
            }
            return null;
        }

        public User Register(User user)
        {
            if (!_helperService.ValidateStringLength(user.FirstName, 2) ||
                !_helperService.ValidateStringLength(user.LastName, 2) ||
                !_helperService.ValidateStringLength(user.UserName, 5))
            {
                return null;
            }
            if (!_helperService.ValidatePassword(user.Password)) return null;


            Users.Add(user);

            return
                Users.LastOrDefault();
        }
        public void SeeAllUsers()
        {
            if (Users == null)
            {
                Console.WriteLine("There is not users yet.");
            }
            Users.ForEach(user => Console.WriteLine(user.DisplayInfo()));

        }
        public void RemoveUserById(int id)
        {
            User userToRemove = Users.FirstOrDefault(u => u.Id == id);
            if (userToRemove != null)
            {
                Users.Remove(userToRemove);
            }
            else
            {
                Console.WriteLine($"There is not user with this id {id} number!");
            }
        }
        //public void ReantAMovie(int id, Movie movie)
        //{
        //    User user = Users
        //                    .Where(u => u.Id == id)
        //                    .SingleOrDefault();

        //    if (_movieService.Movies.Where(m => m.Id == movie.Id) != null)
        //    {
        //        user.Movies.Add(movie);
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The movie with {id} number is already taken, or movie with this id number does not exist. Please choose another.");
        //    }

        //}
        public void ReantAMovie(int userId, int movieId)
        {
            User user = Users
                            .Where(u => u.Id == userId)
                            .SingleOrDefault();
            Movie selectedMovie =_movieService.Movies.Where(m => m.Id == movieId).SingleOrDefault();
            if (selectedMovie.Id == movieId)
            {
                user.Movies.Add(selectedMovie);
            }
            else
            {
                Console.WriteLine($"The movie with {movieId} number is already taken, or movie with this id number does not exist. Please choose another.");
            }

        }
        public void BackRentedMovie(int id, Movie movie)
        {
            User user = Users
                            .Where(u => u.Id == id)
                            .SingleOrDefault();

            if (user.Movies.Where(m => m.Title == movie.Title.ToLower()) != null)
            {
                _movieService.Movies.Add(movie);
            }
            else
            {
                Console.WriteLine($"There is not movie with this id number.");
            }

        }
    }

}

   


