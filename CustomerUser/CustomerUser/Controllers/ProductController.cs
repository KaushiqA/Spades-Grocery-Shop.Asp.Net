using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerUser.EF;

namespace CustomerUser.Controllers
{
    public class ProductController : Controller
    {
        CustomersEntities db = new CustomersEntities();
        private string strCart = "Cart";
        // GET: Product
        public ActionResult Index()
        {
            List<ProductsTbl> products = db.ProductsTbls.ToList<ProductsTbl>(); 
            return View(products);
        }
        //public ActionResult AddToCart(object[] ProductID)
        //{
        //    if (Session["cart"] != null)
        //    {
        //        //List<ProductsTbl> cart = new List<ProductsTbl>();
        //        List<Item> cart = new List<Item>();
        //        cart.Add(new Item(db.ProductsTbls.Find(ProductID),1));
        //        Session["cart"] = cart;

        //    }
        //    else
        //    {

        //    }
        //    return View("Cart");
            
        //}
        public ActionResult OrderNow(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            if (Session[strCart] == null)
            {
                List<Cart> IsCart = new List<Cart>
                {
                    new Cart(db.ProductsTbls.Find(id),1)
                };
                Session[strCart] = IsCart;
            }
            else
            {
                List<Cart> cart = (List<Cart>)Session[strCart];
                cart.Add(new Cart(db.ProductsTbls.Find(id),1));
            }
            return View(strCart);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
