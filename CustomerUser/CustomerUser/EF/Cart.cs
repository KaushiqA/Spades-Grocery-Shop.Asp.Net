using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerUser.EF
{
    public class Cart
    {
        public ProductsTbl Products { get; set; }
        public int Qty { get; set; }

        public Cart (ProductsTbl products, int qty)
        {
            Products = products;
            Qty = qty;
        } 
    }
}