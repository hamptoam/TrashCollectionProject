using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Customer
    {
        [Key]

        [Display(Name = "Id")]
        public int Id { get; set; }
      
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email" )]
        public string Email { get; set; }

        [Display(Name = "Pick-up Address")]
        public string pickUpAddress { get; set; }

        [Display(Name = "Billing Address")]
        public string billingAddress { get; set; } //find out how to do "same as billing address? with checkbox
        
        [Display(Name = "Day Preference")]
        public string dayOfWeek { get; set; }

        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }

}

    
