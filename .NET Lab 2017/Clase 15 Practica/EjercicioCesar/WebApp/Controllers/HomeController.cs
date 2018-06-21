using Business;
using Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    
    public class HomeController : Controller
    {
        static CustomerService service = new CustomerService();

        public ActionResult Index()
        {
            //ViewBag.Title = "Clients C.R.U.D.";
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerDto customer)
        {
            service.AddNewCustomer(customer);
            return View("read", service.ReadCustomers());
        }

        public ActionResult Read()
        {
            return View(service.ReadCustomers());
        }

        
        public ActionResult Update(string customerID)
        {
            if (customerID == null)
                return View("read", service.ReadCustomers());

            var customer = service.ReadCustomer(customerID);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Update(CustomerDto customer)
        {
            service.UpdateServiceCustomer(customer);
            return View("read", service.ReadCustomers());
        }

        public ActionResult Delete(string customerID)
        {
            if (customerID == null)
                return View("read", service.ReadCustomers());

            try
            {
                service.DeleteServiceCustomer(customerID);
            }
            catch(Exception ex)
            {
                
                ViewBag.error = ex.Message;
                
            }

            return View("read", service.ReadCustomers());
        }

    }
}