using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MerchWebsite.Models;
using MerchWebsite.Data;
using Microsoft.EntityFrameworkCore;
using MerchWebsite.Extension;

namespace MerchWebsite.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;

        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            var productList = await context.Products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).ToListAsync();

            return View(productList);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await context.Products.Include(m => m.ProductTypes).Include(m => m.SpecialTags).Where(m => m.Id == id).FirstOrDefaultAsync();

            return View(product);
        }

        [HttpPost, ActionName("Details")]
        [ValidateAntiForgeryToken]
        public IActionResult AddToShoppingCart(int id)
        {
            List<int> shoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if(shoppingCart == null)
            {
                shoppingCart = new List<int>();
            }
            shoppingCart.Add(id);
            HttpContext.Session.Set("ssShoppingCart", shoppingCart);
            return RedirectToAction("About", "Home", new { area = "Customer"});
        }

        public IActionResult Remove(int id)
        {
            List<int> shoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            if(shoppingCart.Count > 0)
            {
                if(shoppingCart.Contains(id))
                {
                    shoppingCart.Remove(id);
                }
            }
            HttpContext.Session.Set("ssShoppingCart", shoppingCart);
            return RedirectToAction(nameof(About));
        }             

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
