using Models_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models_Library.Models
{
    public class Movie 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
        private double Price { get; set; }

        public Movie()
        {

        }
        public Movie(string title, string description, int year, MovieGenre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            
        }
        public void SetPrice()
        {
            if(Year < 2000)
            {
                Price = new Random().Next(100, 200);

            } else if(Year >= 2000 && Year < 2000)
            {
                Price = new Random().Next(200, 300);
            }
            else
            {
                Price = new Random().Next(300, 500);
            }
        }
    }

    

}
