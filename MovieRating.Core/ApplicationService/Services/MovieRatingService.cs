using System;
using System.Collections.Generic;
using MovieRating.Core.Entity;

namespace MovieRating.Core.ApplicationService.Services
{
    public class MovieRatingService : IMovieRatingService
    {
        public MovieRatingService()
        {
        }

        public List<Rating> GetTopRateMovies(int number)
        {
            throw new NotImplementedException();
        }
    }
}
