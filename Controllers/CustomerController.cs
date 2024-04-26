using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var getCustomersList = GetCustomers();
            return View(getCustomersList);
        }
        public ActionResult Detail(int Id)
        {
            var getCustomersList = GetCustomers();
            var getCustomer = getCustomersList.SingleOrDefault(x => x.Id == Id);
            if (getCustomer == null)
                return HttpNotFound();
            return View(getCustomer);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { Id = 1,Name = "Nouman Malik"},
                new Customer() { Id = 2,Name = "Abdul Haseeb"},
                new Customer() { Id = 3,Name = "Haris Ahmed"},
                new Customer() { Id = 4, Name = "Abdul Majeed"},
                new Customer() { Id = 5, Name = "Fazal Maboob"}
            };
        }
    }
}