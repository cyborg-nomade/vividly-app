using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vividly_app.Models;
using vividly_app.ViewModels;

namespace vividly_app.Controllers
{
    public class CustomerController : Controller
    {
        readonly List<Customer> _customers = new List<Customer>()
        {
            new Customer()
            {
                Name = "John Smith",
                Id = 1
            },
            new Customer()
            {
                Name = "Mary Williams",
                Id = 2
            }
        };
        // GET: Customer
        public ActionResult Index()
        {

            var customersList = new CustomerIndexViewModel()
            {
                Customers = _customers
            };

            return View(customersList);
        }

        [Route("Customer/Details/{id}")]
        public ActionResult CustomerDetail(int id)
        {
            var detailedCustomer = _customers.Find(c => c.Id == id);
            Console.WriteLine(detailedCustomer);

            return View(detailedCustomer);
        }
    }
}