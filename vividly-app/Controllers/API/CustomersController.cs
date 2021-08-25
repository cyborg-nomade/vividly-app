using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vividly_app.Models;

namespace vividly_app.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }


    }
}
