using System.Linq;
using MerchWebsite.Data;
using Microsoft.AspNetCore.Mvc;

namespace MerchWebsite.Areas.Customer.Controllers
{
    [Area("Admin")]
    public class AdminUsersController
    {
        private readonly ApplicationDbContext context;
        public AdminUsersController(ApplicationDbContext context)
        {
            this.context = context;

        }

        public IActionResult Index()
        {
            return View(context.ShoppingUser.ToList());
        }
    }
}