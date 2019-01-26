using System.ComponentModel.DataAnnotations;

namespace MerchWebsite.Models
{
    public class ProductTypes
    {
        
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}