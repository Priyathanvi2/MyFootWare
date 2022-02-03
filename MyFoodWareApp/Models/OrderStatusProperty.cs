using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFoodWareApp.Models
{
    public class OrderStatusProperty
    {
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }

    }
}