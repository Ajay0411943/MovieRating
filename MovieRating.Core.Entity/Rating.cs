using System;
namespace MovieRating.Core.Entity
{
    public class Rating
    {
        public Rating()
        {
        }

        public int ReviewerId { get; set; }
        public int MovieId { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}
