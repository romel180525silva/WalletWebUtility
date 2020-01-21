using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WalletWebUtility.Models;

namespace WalletWebUtility.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }
        //POST : Login user authentication
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult UserAuthentication(MobileLogin login)
        {
            if (ModelState.IsValid)
            {
                using (kpmobileDBContext db = new kpmobileDBContext())
                {
                    var response = db.mobilelogin.Where(s => s.username.Equals(login.username) && s.password.Equals(login.password)).FirstOrDefault();
                    if (response != null)
                    {
                        Session["Username"] = response.username.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }


            }

            return View(login);

        }
    }
}