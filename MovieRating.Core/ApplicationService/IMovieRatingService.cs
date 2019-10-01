using System;
using System.Collections.Generic;
using MovieRating.Core.Entity;

namespace MovieRating.Core.ApplicationService
{
    public interface IMovieRatingService
    {

        List<Rating> GetTopRateMovies(int number);
    }
}
