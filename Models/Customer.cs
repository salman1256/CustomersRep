using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
    public class Customer
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public string CCity { get; set; }
        public double CODLimit { get; set; }
       
    }
}