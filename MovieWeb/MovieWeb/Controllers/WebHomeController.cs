using Microsoft.AspNetCore.Mvc;
using MovieWeb.Models;

namespace MovieWeb.Controllers
{
    public class WebHomeController : Controller
    {
        public IActionResult Index()
        {
            Movie movie1 = new Movie();
            movie1.id = 1;
            movie1.title = "Mission Impossible";
            movie1.description = "This is a good Movie";
            movie1.imgUrl = "http://test.com";
            movie1.rating = 8.5f;

            Movie movie2 = new Movie();
            movie2.id = 1;
            movie2.title = "Mission Impossible2";
            movie2.description = "This is a greate Movie";
            movie2.imgUrl = "http://test.com";
            movie2.rating = 10;

            List<Movie> movies = new List<Movie>();
            movies.Add(movie1);
            movies.Add(movie2);
            return View(movies);
        }
    }
}
