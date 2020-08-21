using CustMovMVCAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using CustMovMVCAppWithAuthentication.ViewModel;

namespace CustMovMVCAppWithAuthentication.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var singleCustomer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (singleCustomer == null)
                return HttpNotFound();
            return View(singleCustomer);
        }





        public ActionResult New()         //It will open the form i.e retrivving the form
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        [HttpPost]      //HttpPost bcoz it will be going to post the data in the database
        public ActionResult Create(Customer customer)     //the method name must be in Create() name....that is the convention,we can write CreateNew but it shld strt with Create
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");                                         //this new method to submit the form and the other is going to display method
        }




        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

    }
}