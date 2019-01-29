using System;
using System.Collections.Generic;
using System.Text;
using MerchWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MerchWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductTypes> ProductTypes { get; set;}
        public DbSet<SpecialTags> SpecialTags { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<ShippingProducts> ShippingProducts { get; set; }
        public DbSet<ShoppingUser> ShoppingUser { get; set; }
    }
}
