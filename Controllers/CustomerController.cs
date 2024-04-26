using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext context;

        public CustomerController()
        {
            context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Customer
        public ActionResult Index()
        {
            var getCustomersList = context.Customers.Include(x=>x.MembershipType).ToList();
            return View(getCustomersList);
        }
        public ActionResult Detail(int Id)
        {
            var getCustomer = context.Customers.SingleOrDefault(x => x.Id == Id);
            if (getCustomer == null)
                return HttpNotFound();
            return View(getCustomer);
        }
        
    }
}