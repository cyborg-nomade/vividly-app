using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vividly_app.Models;
using vividly_app.ViewModels;

namespace vividly_app.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {

            var moviesList = _context.Movies.Include(m => m.Genre).ToList();

            return View(moviesList);
        }

        public ActionResult Details(int id)
        {
            var detailedMovie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            return detailedMovie == null ? (ActionResult)HttpNotFound() : View(detailedMovie);
        }

        public ActionResult New()
        {
            var genresList = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel()
            {
                Genres = genresList
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.Genre = movie.Genre;
                movieInDb.ReleaseDate = movieInDb.ReleaseDate;
                movieInDb.NumberInStock = movieInDb.NumberInStock;
                movieInDb.DateAdded = movie.DateAdded;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }


        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            var viewModel = new MovieFormViewModel()
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };

            return movie == null ? (ActionResult)HttpNotFound() : View("MovieForm", viewModel);
        }

        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie { Id = 1, Name = "Shrek" };
            var customers = new List<Customer>()
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}