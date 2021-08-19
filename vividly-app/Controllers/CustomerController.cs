using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vividly_app.Models;
using vividly_app.ViewModels;

namespace vividly_app.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {

            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var detailedCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);

            return detailedCustomer == null ? (ActionResult)HttpNotFound() : View(detailedCustomer);
        }
    }
}