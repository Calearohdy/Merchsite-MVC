using System.Collections.Generic;

namespace MerchWebsite.Models.ViewModels
{
    public class ShippingUserViewModel
    {
        public List<ShoppingUser> ShoppingUsers { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}