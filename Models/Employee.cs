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
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public List<string> PickupList { get; set; }

        public string phoneNumber { get; set; }

        //did this and customer key for migration purposes, continue working on these classes 
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }



}