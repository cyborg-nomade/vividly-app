using System;
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

        // GET /api/rentals
        public IHttpActionResult GetRentals()
        {
            return Ok();
        }

        // GET /api/rentals/1
        public IHttpActionResult GetRental(int id)
        {
            return Ok();
        }

        // POST /api/rentals
        [HttpPost]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            return Ok();
        }

        // PUT /api/rentals/1
        [HttpPut]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult UpdateRental(int id, RentalDto rentalDto)
        {
            return Ok();
        }

        // DELETE /api/rentals/1
        [HttpDelete]
        //[Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult DeleteRental(int id)
        {
            return Ok();
        }
    }
}