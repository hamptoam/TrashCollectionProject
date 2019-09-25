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
        public int CustomerId { get; set; }
      
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email" )]
        public string Email { get; set; }

        [Display(Name = "Day Preference")]
        public DayOfWeek dayOfWeek { get; set; }
  
        [Display(Name = "Pick-Up Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? pickupDate { get; set; }


        [Display(Name = "One-time pickup")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? oneTimePickUpDate { get; set; }
        public string Latitude { get; set; } 
        public string Longitutde { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }



        public enum AccurateToTypes : int
        {
            Unknown = 0,
            Country = 1,
            Reigon = 2,
            SubRegion = 3,
            Town = 4,
            PostCode = 5,
            Street = 6,
            Intersection = 7,
            Address = 8,
            Premises = 9
        }

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

    
