using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using vividly_app.Models;

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
            var detailedCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);

            return detailedCustomer == null ? (ActionResult)HttpNotFound() : View(detailedCustomer);
        }
    }
}