using NUnit.Framework;

namespace AndroidDemo.API.Service.Tests
{
    [TestFixture]
    public class MovieServiceIntegrationTest
    {
        [Test]
        public void GetMovies()
        {
            var service = new MovieService();
            var movies = service.GetMovies();

            Assert.AreEqual(movies.Count,15);
        }
    }
}
