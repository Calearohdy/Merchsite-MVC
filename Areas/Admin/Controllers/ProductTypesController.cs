using System.Linq;
using System.Threading.Tasks;
using MerchWebsite.Data;
using MerchWebsite.Models;
using MerchWebsite.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MerchWebsite.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.AdminEndUser)]
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        private readonly ApplicationDbContext _context; // dependancy injection
        public ProductTypesController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index() // action method
        {
            return View(_context.ProductTypes.ToList()); // referencing the database table ProductTypes from DbContext
        }

        public IActionResult Create() //GET Create Action Method
        {
            return View();
        }

        [HttpPost] //POST Create action method
        [ValidateAntiForgeryToken] // security token passed along with the request
        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            if(ModelState.IsValid)
            {
                _context.Add(productTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); //nameof helps remove spelling mistakes
            }
            return View(productTypes);
        }

        public async Task<IActionResult> Edit(int? id) //GET Edit Action Method
        {
            if(id == null)
            {
                return BadRequest();
            }

            var productType = await _context.ProductTypes.FindAsync(id);
            if(productType == null)
            {
                return BadRequest();
            }
            return View(productType);
        }

        [HttpPost] //POST Edit action method
        [ValidateAntiForgeryToken] // security token passed along with the request
        public async Task<IActionResult> Edit(int id, ProductTypes productTypes)
        {
            if(id != productTypes.Id)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _context.Update(productTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); //nameof helps remove spelling mistakes
            }
            return View(productTypes);
        }

        public async Task<IActionResult> Details(int? id) //GET Details Action Method
        {
            if(id == null)
            {
                return BadRequest();
            }

            var productType = await _context.ProductTypes.FindAsync(id);
            if(productType == null)
            {
                return BadRequest();
            }
            return View(productType);
        }

        public async Task<IActionResult> Delete(int? id) //GET Delete Action Method
        {
            if(id == null)
            {
                return BadRequest();
            }

            var productType = await _context.ProductTypes.FindAsync(id);
            if(productType == null)
            {
                return BadRequest();
            }
            return View(productType);
        }

        [HttpPost] //POST Delete action method
        [ValidateAntiForgeryToken] // security token passed along with the request
        public async Task<IActionResult> Delete(int id)
        {
            var productTypes = await _context.ProductTypes.FindAsync(id);
            _context.Remove(productTypes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}