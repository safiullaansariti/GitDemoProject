using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitDemoProject1.Model
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNo { get; set; }

        public string MobileNo { get; set; }
         
        public bool RememberMe { get; set; }
    }
}