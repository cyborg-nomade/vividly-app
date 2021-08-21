﻿using System.Data.Entity;
using System.Linq;
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

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var detailedCustomer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            return detailedCustomer == null ? (ActionResult)HttpNotFound() : View(detailedCustomer);
        }

        public ActionResult New()
        {
            var membershipTypesList = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershipTypesList
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
    }
}