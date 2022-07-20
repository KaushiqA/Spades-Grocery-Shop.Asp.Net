/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerUser.Controllers;
using CustomerUser.EF;

namespace CustomerUser.Controllers
{
    public class Item
    {
        private ProductsTbl pr = new ProductsTbl();

        public ProductsTbl Pr 
        { 
            get { return pr; }
            set { pr = value; }
        }
        
        private int Qty;

        public Item()
        {

        }
        public Item(ProductsTbl ProductsTbls, int Qty)
        {
             this.pr = ProductsTbls;
            this.Qty = Qty;
        }

       
        public int Qty1 { get => Qty; set => Qty = value; }
       
    }
}*/