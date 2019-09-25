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

        [Display(Name = "Day Preference")]
        public string dayOfWeek { get; set; }

        [Display(Name = "Pick-Up Date")]
        [DataType(DataType.Date)]
        public DateTime? pickupDate { get; set; }

        [Display(Name = "One-time pickup")]
        [DataType(DataType.Date)]
        public DateTime? oneTimePickUpDate { get; set; }

        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [Display(Name = "Monthly Balance")]
        public int balance = 0;

        [Display(Name = "Payment Due Date")]
        public DateTime? dueDate { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? startDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? endDate { get; set; }

        [Display(Name = "5-digit Zipcode")]
        public string zipCode { get; set; }

        [Display(Name = "Trash Picked Up?")]
        public bool isPickedUp { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }

}

    
