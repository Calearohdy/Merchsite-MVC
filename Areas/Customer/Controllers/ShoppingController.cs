using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MerchWebsite.Data;
using MerchWebsite.Models;
using MerchWebsite.Extension;
using MerchWebsite.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace MerchWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShoppingCartController : Controller
    {
        [BindProperty]
        public ShoppingCartViewModel ShoppingCartVM { get; set; }
        private readonly ApplicationDbContext context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            this.context = context;
            ShoppingCartVM = new ShoppingCartViewModel()
            {
                Products = new List<Products>()
            };
        }

        public IActionResult Index()
        {
            List<int> shoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");

            if(shoppingCart.Count > 0)
            {
                foreach(int cartItem in shoppingCart)
                {
                    Products prod = context.Products.Include(m => m.SpecialTags).Include(m => m.ProductTypes).Where(p => p.Id == cartItem).FirstOrDefault();
                    ShoppingCartVM.Products.Add(prod);
                }
            }

            return View(ShoppingCartVM);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public IActionResult ShippingPost()
        {
            List<int> shoppingCart = HttpContext.Session.Get<List<int>>("ssShoppingCart");
            ShoppingCartVM.Shipping.ShippingDate = ShoppingCartVM.Shipping.ShippingDate
                                                        .AddHours(ShoppingCartVM.Shipping.ShippingTime.Hour)             
                                                        .AddMinutes(ShoppingCartVM.Shipping.ShippingTime.Minute);
            Shipping shipping = ShoppingCartVM.Shipping;
            context.Shipping.Add(shipping);
            context.SaveChanges();

            int shippingId = shipping.Id;

            foreach (int productId in shoppingCart)
            {
                ShippingProducts shippingProducts = new ShippingProducts
                {
                    ShippingId = shippingId,
                    ProductId = productId
                };

                context.ShippingProducts.Add(shippingProducts);
            }
            context.SaveChanges();
            shoppingCart = new List<int>();
            HttpContext.Session.Set("ssShoppingCart", shoppingCart);

            return RedirectToAction("ShoppingConfirmation", "ShoppingCart", new { Id = shippingId});
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

                return RedirectToAction(nameof(Index));
        }

        public IActionResult ShoppingConfirmation(int id)
        {
            ShoppingCartVM.Shipping = context.Shipping.Where(m => m.Id == id).FirstOrDefault();
            List<ShippingProducts> objProdList = context.ShippingProducts.Where(m => m.ShippingId == id).ToList();

            foreach(ShippingProducts shippingProduct in objProdList)
            {
                ShoppingCartVM.Products.Add(context.Products.Include(p => p.ProductTypes).Include(p => p.SpecialTags).Where(p => p.Id == shippingProduct.ProductId).FirstOrDefault());
            }

            return View(ShoppingCartVM);
        }
    }
}