
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MerchWebsite.Models
{
    public class Shipping
    {
        public int Id { get; set; }
        
        public DateTime ShippingDate { get; set; }

        [NotMapped]
        public DateTime ShippingTime { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public bool isConfirmed { get; set; }
    }
}