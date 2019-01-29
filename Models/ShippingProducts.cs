using System.ComponentModel.DataAnnotations.Schema;

namespace MerchWebsite.Models
{
    public class ShippingProducts
    {
        public int Id { get; set; }
        public int ShippingId { get; set; }

        [ForeignKey("ShippingId")]
        public virtual Shipping Shipping { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }
    }
}