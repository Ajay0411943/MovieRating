using System;
using System.Collections.Generic;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entity;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class MovieRatingRepository : IMovieRatingRepository
    { 
        public MovieRatingRepository()
        {
            
        }

        public Rating AddRating(int reviewerId, int movieId, int grade, DateTime Date)
        {
            FakeMovieRatingRepository fakerepo = new FakeMovieRatingRepository();
            fakerepo.AddRating(new Rating(1, 1, 5, DateTime.Now));



            return null;
        }


        public List<Rating> GetTopRateMovies(int number)
        {
            throw new NotImplementedException();


        }
    }
}
