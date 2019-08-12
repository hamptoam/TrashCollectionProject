using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your Account Details";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pay Bill";

            return View();
        }
    }
}