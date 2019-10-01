using System;
using System.Collections.Generic;
using MovieRating.Core.Entity;

namespace MovieRating.Infrastructure.Data
{
    public class FakeDB
    {
        private static List<Rating> _ratings = new List<Rating>();

        static FakeDB()
        {
            InitRating();
        }

        public static void InitRating()
        {
            Rating rating1 = new Rating() { ReviewerId = 1, MovieId = 1, Grade = 5, Date = DateTime.Parse("9/14/2017") };
            Rating rating2 = new Rating() { ReviewerId = 2, MovieId = 1, Grade = 5, Date = DateTime.Parse("9/14/2017") };
            Rating rating3 = new Rating() { ReviewerId = 3, MovieId = 1, Grade = 4, Date = DateTime.Parse("9/14/2017") };
        }


        public static List<Rating> GetAllRatings()
        {
            return _ratings;
        }
    }
}
