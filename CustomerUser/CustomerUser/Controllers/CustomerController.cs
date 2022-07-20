using CustomerUser.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;




namespace CustomerUser.Controllers
{
    public class CustomerController : Controller
    {
        CustomersEntities entity = new CustomersEntities();
        // GET: Customer
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(EF.LoginViewModel credentials )
        {
            bool userExist = entity.CustomersTbls.Any(x => x.Email == credentials.Email && x.Passcode == credentials.Password);
            CustomersTbl c = entity.CustomersTbls.FirstOrDefault(x => x.Email == credentials.Email && x.Passcode == credentials.Password);
            
            if (userExist)
            {
                FormsAuthentication.SetAuthCookie(c.FName, false);
                return RedirectToAction("Index", "Product");
            }
            ModelState.AddModelError("", "Username or Password is wrong");

            return View();

        }
        [HttpGet]
       // public ActionResult Signup()
        public ActionResult Signup(int id=0)
       {
           /* try
            {
                if (Session["FName"] == null)
                {
                    return RedirectToAction("Signup", "Customer");
                }
            }
            catch
            {
                return RedirectToAction("Signup", "Manager");
            }
            return View();*/
  
      
            CustomersTbl userModel = new CustomersTbl();
            //entity.CustomersTbls.Add(userinfo);
            //entity.SaveChanges();
           return View(userModel); ;
            //return RedirectToAction("Login", "Customer");
       }

        [HttpPost]
        public ActionResult Signup(CustomersTbl userModel)
        // public ActionResult Signup(CustomersTbl userinfo)
        {
            var db = new CustomersEntities();
            if (ModelState.IsValid)
            {
                db.CustomersTbls.Add(userModel);
                db.SaveChanges();
            }
            //return RedirectToAction("Login");
            return View(userModel);
            
           
            //entity.CustomersTbls.Add(userModel);


            // using (CustomersEntities dbModel = new CustomersEntities())
            //{
            //dbModel.CustomersTbls.Add(userModel);
            //dbModel.SaveChanges();
            //}
            // ModelState.Clear();

            //entity.CustomersTbls.Add(userinfo);
            //entity.SaveChanges();
            //return View(userinfo);

        }

        public ActionResult Order()
        {
            return View();
        }


        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}