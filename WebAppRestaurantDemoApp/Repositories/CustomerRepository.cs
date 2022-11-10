using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class CustomerRepository
    {
        private  RestaurantDBEntities1 objrestaurantDBEntities1;
        public CustomerRepository()
        {
            objrestaurantDBEntities1 = new RestaurantDBEntities1();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            
            
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objrestaurantDBEntities1.Customers
                                    select new SelectListItem
                                    {
                                        Text = obj.CustomerName,
                                        Value = obj.CustomerId.ToString(),
                                        //Text = obj.Billing_Address,
                                        //Text = obj.Shipping_Address,
                                        //Text = obj.Phone_no.ToString(),
                                        //Text = obj.Email.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}