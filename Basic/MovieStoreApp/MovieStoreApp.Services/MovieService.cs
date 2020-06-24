using Models_Library.Enums;
using Models_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStoreApp.Services
{
    public class MovieService
    {
        private static UserService _userService = new UserService();

        public List<Movie> Movies { get; set; }

        public MovieService()
        {
            Movies = new List<Movie>
            {
                new Movie("The Shawshank Redemption","Inspirational drama movie.",new DateTime(1994, 10, 10), MovieGenre.drama),
                new Movie("The Godfather","Life of the italian mafia family.",new DateTime(1972, 12, 01), MovieGenre.crimi),
                new Movie("The Dark Knight","Good action movie.",new DateTime(2008, 03, 03), MovieGenre.action),
                new Movie("Schindler's List","Movie about Jews in second WW.",new DateTime(1993, 07, 05), MovieGenre.history),
                new Movie("The Irishman","Mafia movie.",new DateTime(2019, 11, 11), MovieGenre.crimi),


            };

        }


        public void printAllMovies()
        {
            if (Movies == null)
            {
                Console.WriteLine("There are not available movies at this moment, please check a little later.");
                return;
            }
            foreach (Movie movie in Movies)
            {
                movie.SetPrice();
                Console.WriteLine(movie.MovieInfo());
            }
        }
        //public void RentMovie(int id, User user)
        //{
        //    Movie movie = Movies
        //                    .Where(m => m.Id == id)
        //                    .SingleOrDefault();

        //    if(movie == null)
        //    {
        //        Console.WriteLine($"The movie with {id} number is already taken, or movie with this id number does not exist. Please choose another.");
        //    }
        //    else
        //    {
        //        user.Movies.Add(movie);
        //    }

        //}
    }
}
