using Models_Library.Enums;
using Models_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreApp.Services
{
    public class MovieService
    {
        public Movie[] Movies { get; set; }

        public MovieService()
        {
            Movies = new Movie[]
            {
                new Movie("The Shawshank Redemption","Inspirational drama movie.",1994, MovieGenre.drama),
                new Movie("The Godfather","Life of the italian mafia family.",1972, MovieGenre.crimi),
                new Movie("The Dark Knight","Good action movie.",2008, MovieGenre.action),
                new Movie("Schindler's List","Movie about Jews in second WW.",1993, MovieGenre.history),
                new Movie("The Irishman","Mafia movie.",2019, MovieGenre.crimi),


            };

        }

        
        public void printAllMovies()
        {
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie.MovieInfo());
            }
        }
        
            
        
    }
}
