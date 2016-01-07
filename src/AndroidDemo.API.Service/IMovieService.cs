using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndroidDemo.API.Service.Model;

namespace AndroidDemo.API.Service
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
    }
}
