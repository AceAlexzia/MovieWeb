using Microsoft.AspNetCore.Mvc;
using MovieWeb.Data;
using MovieWeb.Models;
using System.Net;

namespace MovieWeb.Controllers
{
    public class WebHomeController : Controller
    {
        private readonly ApplicationDBContext _db;
        public WebHomeController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Movie> movies = _db.Movies;
            return View(movies);
        }

        // GET Method for showing Form webpage without this it will be unable to open the create form page
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}
