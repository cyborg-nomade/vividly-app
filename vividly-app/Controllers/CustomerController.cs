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
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
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
        }

        // GET: Customer
        public ActionResult Index()
        {

            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var detailedCustomer = GetCustomers().SingleOrDefault(c => c.Id == id);

            return detailedCustomer == null ? (ActionResult)HttpNotFound() : View(detailedCustomer);
        }
    }
}