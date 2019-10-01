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

        public List<Rating> GetTopRateMovies(int number)
        {
            throw new NotImplementedException();


        }
    }
}
