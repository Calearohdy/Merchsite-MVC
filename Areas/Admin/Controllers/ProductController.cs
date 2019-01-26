using System.Linq;
using System.Threading.Tasks;
using MerchWebsite.Data;
using MerchWebsite.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MerchWebsite.Areas.Admin.Controllers
{
    [Area("Admin")] // Tells template: "{area=^*}/{controller=^*}/{action=^*}/{id?}");
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context; // local object

        [BindProperty]
        public ProductsViewModel ProductVm { get; set; }
        
        public ProductController(ApplicationDbContext context)
        {
            _context = context; // injected object
            ProductVm = new ProductsViewModel() // new instance of an object
            {
                ProductTypes = _context.ProductTypes.ToList(),
                SpecialTags = _context.SpecialTags.ToList(),
                Products = new Models.Products() // new instance of Products model
            };

        }

        public async Task<IActionResult> Index()
        {
            var products = _context.Products.Include(m => m.ProductTypes).Include(m => m.SpecialTags);
            return View(await products.ToListAsync());
        }
    }
}