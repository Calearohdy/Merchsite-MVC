using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MerchWebsite.Models
{
    public class ShoppingUser : IdentityUser
    {
        public string Name { get; set; }

        [NotMapped]
        public bool isAdmin { get; set; }
    }
}