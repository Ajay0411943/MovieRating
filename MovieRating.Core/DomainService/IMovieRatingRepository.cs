using System;
using System.Collections.Generic;
using MovieRating.Core.Entity;

namespace MovieRating.Core.DomainService
{
    public interface IMovieRatingRepository
    {

        List<MovieRating> GetTopMovies(int number);
       
    }
}
