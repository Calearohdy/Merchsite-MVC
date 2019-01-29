
using System.Collections.Generic;

namespace MerchWebsite.Models.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Products> Products { get; set; }
        public Shipping Shipping { get; set; }
    }
}