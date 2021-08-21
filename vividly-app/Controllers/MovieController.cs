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