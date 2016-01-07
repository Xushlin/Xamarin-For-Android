using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AndroidDemo.API.Models;
using AndroidDemo.API.Service;

namespace AndroidDemo.API.Controllers
{
    public class MovieController : ApiController
    {
        [Route("api/movies")]
        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            var service = new MovieService();
            var movies = service.GetMovies();

            return movies?.Select(x => x.ToModel());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
    }
}