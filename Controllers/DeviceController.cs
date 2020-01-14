using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WalletWebUtility.Models;

namespace WalletWebUtility.Controllers
{
    public class DeviceController : Controller
    {
        private kpmobileDBContext db = new kpmobileDBContext();
        // GET: Device
        public ActionResult Index()
        {
            var returnview = db.devices.ToList();          
            return View(returnview);
        }
    }
}