using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WebAppRestaurantDemoApp.Models;

namespace WebAppRestaurantDemoApp.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities1 restaurantDBEntities1;
        public PaymentTypeRepository()
        {
            objrestaurantDBEntities1 = new RestaurantDBEntities1();
        }

        public RestaurantDBEntities1 objrestaurantDBEntities1 { get; private set; }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (
                                    from obj in objrestaurantDBEntities1.PaymentTypes
                                    select new SelectListItem
                                    {
                                        Text = obj.PaymentTypeName,
                                        Value = obj.PaymentTypeId.ToString(),
                                        Selected = true
                                    }
                                ).ToList();

            return objSelectListItems;
        }
    }
}