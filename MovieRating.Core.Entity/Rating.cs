﻿using System;
namespace MovieRating.Core.Entity
{
    public class Rating
    {
        public Rating() { }

        public Rating(int reviewerId, int movieId, int grade, DateTime Date)
        {
            ReviewerId = reviewerId;
            MovieId = movieId;
            Grade = grade;
           Date = Date;

        }

        public int ReviewerId { get; set; }
        public int MovieId { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
