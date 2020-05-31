using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library.Models
{
    public class Movie 
    {
        private static int _idGenerator = 0;
        public string Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public MovieGenre Genre { get; set; }
        private double Price { get; set; }

        public Movie()
        {

        }
        public Movie(string title, string description, DateTime year, MovieGenre genre)
        {
            _idGenerator++;
            Title = title;
            Id = _idGenerator;
            Description = description;
            Year = year;
            Genre = genre;
            
        }
        public double SetPrice()
        {
            if(Year.Year < 2000)
            {
                Price = new Random().Next(5, 10);

            } else if(Year.Year >= 2000 && Year.Year < 2000)
            {
                Price = new Random().Next(11, 17);
            }
            else
            {
                Price = new Random().Next(18, 25);
            }
            return Price;
        }
        
        public string MovieInfo()
        {
            return 
                $"{Title} - {Genre} {Year.Year}y, price - {Price}$ (Id #{Id}).";
        }
    }

    

}
