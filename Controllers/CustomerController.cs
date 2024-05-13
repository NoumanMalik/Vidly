using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Xml.Schema;
using Vidly.Models;
using Vidly.ViewModel;

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
        #region Customers List
        // GET: Customer
        public ActionResult Index()
        {
            var getCustomersList = context.Customers.Include(x=>x.MembershipType).ToList();
            return View(getCustomersList);
        }
        #endregion
        #region Customer Detail
        public ActionResult Detail(int Id)
        {
            var getCustomer = context.Customers.Include(x=>x.MembershipType).SingleOrDefault(x => x.Id == Id);
            if (getCustomer == null)
                return HttpNotFound();
            return View(getCustomer);
        }
        #endregion
        #region Customer Add/Update
        public ActionResult New()
        {
            var membershipType = context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipType = membershipType
            };
            return View("Save",viewModel);
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.Id == 0)
                context.Customers.Add(customer);
            else
            {
                var model = context.Customers.Single(x => x.Id == customer.Id);
                model.Name = customer.Name;
                model.DateOfBirth = customer.DateOfBirth;
                model.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                model.MembershipTypeId = customer.MembershipTypeId;
            }
            context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }
        public ActionResult Edit(int id)
        {
            var customer = context.Customers.Single(x => x.Id == id);
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipType= context.MembershipTypes.ToList()
            };
            return View("Save", viewModel);
        }
        #endregion
    }
}