using System.Collections.Generic;
using AndroidDemo.API.Service.Model;

namespace AndroidDemo.API.Service
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
    }
}
