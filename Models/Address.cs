using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
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
    }
}