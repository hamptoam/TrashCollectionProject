using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        public string employeeAddress { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Pickups")]
        public List<Customer> pickupList { get; set; }

        [Display(Name = "Employee Phone Number")]
        public string PhoneNumber { get; set; }

        public List<Customer> Customers { get; set; }

        //did this and customer key for migration purposes, continue working on these classes 
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

     
    }
}