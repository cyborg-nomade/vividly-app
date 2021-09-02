using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using vividly_app.DTOs;
using vividly_app.Models;

namespace vividly_app.Controllers.API
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST /api/rentals
        [HttpPost]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            var customer = _context.Customers.Single(c => c.Id == rentalDto.CustomerId);

            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available");
                }
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

        // GET /api/rentals
        //public IHttpActionResult GetRentals()
        //{
        //    return Ok();
        //}


        // GET /api/rentals/1
        //public IHttpActionResult GetRental(int id)
        //{
        //    return Ok();
        //}

        // PUT /api/rentals/1
        //[HttpPut]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        //public IHttpActionResult UpdateRental(int id, RentalDto rentalDto)
        //{
        //    return Ok();
        //}

        // DELETE /api/rentals/1
        //[HttpDelete]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        //public IHttpActionResult DeleteRental(int id)
        //{
        //    return Ok();
        //}
    }
}