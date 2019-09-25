using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollection.Models
{
    public class CustomerAddress
    {
        [Key]
        public int GeoCodingId { get; set; }

 
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


        [ForeignKey("Address")]
        public int Id { get; set; }
        public Address Address { get; set; }
    }
}