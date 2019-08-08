using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public AddPhoneNumberViewModel PhoneNumber { get; set; }

        //did this and customer key for migration purposes, continue working on these classes 

    }
}