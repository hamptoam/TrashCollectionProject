using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class UserController : Controller 
    {
        public ApplicationDbContext context;
        public ApplicationUserManager UserManager;


        public UserController()
        {



        }



        // GET: User
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;

                ViewBag.displayMenu = "Yes";

                return View();
            }

            else
            {
                ViewBag.Name = "Not Logged IN";
            }
            return View();
        }

    }
}