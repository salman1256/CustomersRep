using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomerList()
        {
            List<Customer> listCust = new List<Customer>
            {
             new Customer{ CId=1,CName="Sam",CCity="Delhi",CODLimit=500000.90},
             new Customer{ CId=1,CName="Neha",CCity="Mumbai",CODLimit=450000.90},
              new Customer{ CId=4,CName="Vipul",CCity="Pune",CODLimit=900000.90},
               new Customer{ CId=5,CName="Nitu",CCity="Goa",CODLimit=800000.90},
                new Customer{ CId=8,CName="Raj",CCity="Delhi",CODLimit=900000.90},
            };
            return View(listCust);
        }
        
    }
}