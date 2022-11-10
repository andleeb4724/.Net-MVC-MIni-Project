using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppRestaurantDemoApp.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Billing_Address { get; set; }
        public string Shipping_Address { get; set; }
        public string Phone_no { get; set; }
        public string Email { get; set; }
    }
}