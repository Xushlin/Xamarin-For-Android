using System.Collections.Generic;
using System.Threading.Tasks;
using AndroidDemo.Infrastructure;
using AndroidDemo.Service.Model;

namespace AndroidDemo.Service
{
    public class MovieService
    {
        public static async Task<List<Movie>> GetMoviesAsync()
        {
            var httpClientProvider = new HttpClientProvider<List<Movie>>();
            var movies = await httpClientProvider.GetAsync(Config.MoviesUrl);

            return movies;
        }
    }
}
