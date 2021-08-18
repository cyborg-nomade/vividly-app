using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vividly_app.Models;
using vividly_app.ViewModels;

namespace vividly_app.Controllers
{
    public class MovieController : Controller
    {
        readonly List<Movie> _movies = new List<Movie>()
        {
            new Movie()
            {
                Name = "Shrek"
            },
            new Movie()
            {
                Name = "Wall-e"
            }
        };

        // GET: Movie
        public ActionResult Random()
        {
            var customers = new List<Customer>()
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = _movies[0],
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {

            var moviesList = new MovieIndexViewModel()
            {
                Movies = _movies
            };

            return View(moviesList);
        }
    }
}