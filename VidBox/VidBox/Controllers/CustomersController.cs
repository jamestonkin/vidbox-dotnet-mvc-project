using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidBox.Models;

namespace VidBox.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleorDefault(c => c.Id == id);

            if (customer == null)
                return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer() {Id = 1, Name = "Jordan Nelson"},
                new Customer() {Id = 2, Name = "Dean Smith"}
            };
        }
    }
}