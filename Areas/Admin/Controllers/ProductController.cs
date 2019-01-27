using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MerchWebsite.Data;
using MerchWebsite.Models;
using MerchWebsite.Models.ViewModels;
using MerchWebsite.Util;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MerchWebsite.Areas.Admin.Controllers
{
    [Area("Admin")] // Tells template: "{area=^*}/{controller=^*}/{action=^*}/{id?}");
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context; // local object
        private readonly HostingEnvironment _hostingEnv;

        [BindProperty]
        public ProductsViewModel ProductVm { get; set; }


        public ProductController(ApplicationDbContext context, HostingEnvironment hostingEnv)
        {
            _hostingEnv = hostingEnv; // assigning local obj to the injected obj
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

        public IActionResult Create() //Get Action method: Create
        {
            return View(ProductVm);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost() // param is binded at the top of the file
        {
            if (!ModelState.IsValid)
            {
                return View(ProductVm);
            }

            _context.Add(ProductVm.Products);
            await _context.SaveChangesAsync();

            //Immage being saved
            string webRootPath = _hostingEnv.WebRootPath;
            var files = HttpContext.Request.Form.Files;
            var productsFromDb = _context.Products.Find(ProductVm.Products.Id);

            if(files.Count != 0)
            {
                //Image has been uploaded
                var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                var extension = Path.GetExtension(files[0].FileName);

                using (var filestream = new FileStream(Path.Combine(uploads, ProductVm.Products.Id + extension),FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }
                productsFromDb.Image = @"\"+SD.ImageFolder + @"\" + ProductVm.Products.Id + extension;
                
            } else
            {
                //when user does not upload image
                var uploads = Path.Combine(webRootPath, SD.ImageFolder + @"\" + SD.DefaultProductImage);
                System.IO.File.Copy(uploads, webRootPath + @"\" + SD.ImageFolder + @"\" + ProductVm.Products.Id + ".jpg");
                productsFromDb.Image = @"\" + SD.ImageFolder + @"\" + ProductVm.Products.Id + ".jpg";
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id) //GET action method for Edit
        {
            if(id == null)
            {
                return NotFound();
            }

            ProductVm.Products = await _context.Products.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if(ProductVm.Products ==  null)
            {
                return NotFound();
            }

            return View(ProductVm);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if(ModelState.IsValid)
            {
                string webRootPath = _hostingEnv.WebRootPath;
                var files = HttpContext.Request.Form.Files;

                var productsFromDb = _context.Products.Where(m => m.Id == ProductVm.Products.Id).FirstOrDefault();

                if(files.Count > 0 && files[0] != null)
                {
                    var uploads = Path.Combine(webRootPath, SD.ImageFolder);
                    var extensionNew = Path.GetExtension(files[0].FileName);
                    var extensionOld = Path.GetExtension(productsFromDb.Image);

                    if(System.IO.File.Exists(Path.Combine(uploads, ProductVm.Products.Id + extensionOld)))
                    {
                        System.IO.File.Delete(Path.Combine(uploads, ProductVm.Products.Id + extensionOld));
                    };
                    using (var filestream = new FileStream(Path.Combine(uploads, ProductVm.Products.Id + extensionOld),FileMode.Create))
                    {
                        files[0].CopyTo(filestream);
                    }
                    ProductVm.Products.Image = @"\"+SD.ImageFolder + @"\" + ProductVm.Products.Id + extensionNew;
                }

                if(ProductVm.Products.Image != null)
                {
                    productsFromDb.Image = ProductVm.Products.Image;
                }

                productsFromDb.Name = ProductVm.Products.Name;
                productsFromDb.Price = ProductVm.Products.Price;
                productsFromDb.Available = ProductVm.Products.Available;
                productsFromDb.ProductTypeId = ProductVm.Products.ProductTypeId;
                productsFromDb.SpecialTagsId = ProductVm.Products.SpecialTagsId;
                productsFromDb.DesignStyle = ProductVm.Products.DesignStyle;
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(ProductVm);
        }

        public async Task<IActionResult> Details(int? id) //GET action method for Details
        {
            if(id == null)
            {
                return NotFound();
            }

            ProductVm.Products = await _context.Products.Include(m => m.SpecialTags).Include(m => m.ProductTypes).SingleOrDefaultAsync(m => m.Id == id);

            if(ProductVm.Products ==  null)
            {
                return NotFound();
            }

            return View(ProductVm);
        }

        public async Task<IActionResult> Delete(int? id) //GET action method for Delete
        {
            if(id == null)
                return BadRequest();

            ProductVm.Products = await _context.Products.FindAsync(id);
            
            if(ProductVm.Products == null)
                return BadRequest();

            return View(ProductVm);    
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            string webRootPath = _hostingEnv.WebRootPath;
            Products product = await _context.Products.FindAsync(id);

            if(product == null)
                return NotFound();

            var uploads = Path.Combine(webRootPath, SD.ImageFolder);
            var extensions = Path.GetExtension(product.Image);

            if(System.IO.File.Exists(Path.Combine(uploads, product.Id + extensions)))
                System.IO.File.Delete(Path.Combine(uploads, product.Id + extensions));    

            _context.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        } 
    }
}