using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Xml.Linq;
using TrashCollection.Models;

namespace TrashCollection.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Employees
        public ActionResult Index(string FirstName)
        {
            var user = db.Customers.Where(u => u.FirstName == FirstName).Include(m => m.ApplicationUser).FirstOrDefault();
            List<Customer> pickupList = new List<Customer>();

            foreach (Customer customer in db.Customers)
            {
                if (customer.pickupDate.ToString() == DateTime.Now.ToString())
                {

                    pickupList.Add(customer);
                    return View(pickupList);

                }
               
      
            }

            return View(pickupList);
        }

        public bool PickedUp(Customer customer, bool? isPickedUp)
        {
            if (customer.isPickedUp == true)
            {
                 
                int newBalance = (customer.balance + 10);
                customer.balance = newBalance;
           
            }
            return (customer.isPickedUp == true);
        }

        // GET: Employees/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,Address,PhoneNumber")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();
                employee.ApplicationId = userId;
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FirstName,LastName,Address,PhoneNumber")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Maps(CustomerAddress customerAddress)
        {
            var user = db.Customer.CustomerAddress.Where(u => u.Id).Include(m => m.ApplicationUser).FirstOrDefault();
            List<Customer> pickupList = new List<Customer>();

            foreach (Customer customer in db.Customers)
            {
                if (customer.pickupDate.ToString() == DateTime.Now.ToString())
                {

                    pickupList.Add(customer);
                    return View(pickupList);

                }

                Address address = new Address();

                var url = string.Format("http://maps.google.com/maps/geo?q={0} +{1} +{2} +{3} +{4}&output=xml&oe=utf8&sensor=false&key={5}", Address1, City, ", ", State, Zip, GoogleKey);
                var webClient = new WebClient();

                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                XDocument xdoc = XDocument.Load(response.GetResponseStream());

                XElement result = xdoc.Element("GeocodeResponse").Element("result");
                XElement locationElement = result.Element("geometry").Element("location");
                XElement lat = locationElement.Element("lat");
                XElement lng = locationElement.Element("lng");

            }
              return View();
        }
           
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
