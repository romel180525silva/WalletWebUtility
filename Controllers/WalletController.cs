using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WalletWebUtility.Models;

namespace WalletWebUtility.Controllers
{
    public class WalletController : Controller
    {
        private kpmobileDBContext db = new kpmobileDBContext();
        // GET: Wallet
        public ActionResult Index(string PageSize, string searchString)
        {
            int a = Convert.ToInt32(String.IsNullOrEmpty(PageSize) ? "10" : PageSize);
            var returnview = db.mobilelogin.ToList().Take(a);
            if (!String.IsNullOrEmpty(searchString))
            {
                returnview = db.mobilelogin.Where(s => s.walletno.Contains(searchString));
            }
            return View(returnview);
        }
        public ActionResult IndexSort(string PageSize)
        {
            int a = Convert.ToInt32(String.IsNullOrEmpty(PageSize) ? "10" : PageSize);
            var returnview = db.mobilelogin.ToList().Take(a);
            return PartialView("~/Views/Wallet/_WalletUsersTable.cshtml", returnview);
        }
       
    }
}