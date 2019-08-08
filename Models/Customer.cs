using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Customer
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }


    }
}

    
