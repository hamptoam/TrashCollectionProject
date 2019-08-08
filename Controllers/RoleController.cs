using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class RoleController : UserController
    {

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            IdentityRole Role = new IdentityRole();
            return View(Role);
        }

        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            UserController usercontroller = new UserController();

          /*  if (User.Identity.IsAuthenticated)
            {

                if (!isAdminUser())
                {
                    return RedirectToAction("Index, Home");
                }

            }
            else
            {
                return RedirectToAction("Index, Home");
            }

            */

            ApplicationDbContext context = new ApplicationDbContext();
            var Roles = context.Roles.ToList();
            return View();
        }
    }
}