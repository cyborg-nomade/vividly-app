using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vividly_app.Models;

namespace vividly_app.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}