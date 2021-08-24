using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vividly_app.Models;

namespace vividly_app.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Title => Movie != null && Movie.Id != 0 ? "Edit Movie" : "New Movie";
    }
}