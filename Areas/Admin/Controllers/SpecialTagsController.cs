using System.Linq;
using System.Threading.Tasks;
using MerchWebsite.Data;
using MerchWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace MerchWebsite.Areas.Admin.Controllers
{
    [Area("Admin")] // Tells template: "{area=*}/{controller=*}/{action=*}/{id?}");
    public class SpecialTagsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SpecialTagsController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            return View(_context.SpecialTags.ToList());
        }

        public IActionResult Create() //GET Create Action Method
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTags specialTags)
        {
            if(ModelState.IsValid)
            {
                _context.Add(specialTags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           return View(specialTags);
        }

        public async Task<IActionResult> Edit(int? id) //GET Edit Action Method
        {
            if(id == null)
            {
                return BadRequest();
            }
            var specialTags = await _context.SpecialTags.FindAsync(id);
            if(specialTags == null)
            {
                return BadRequest();
            }
            
            return View(specialTags);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SpecialTags specialTags)
        {
            if(id != specialTags.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                _context.Update(specialTags);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           return View(specialTags);
        }

        public async Task<IActionResult> Details(int? id) //GET Details Action Method
        {
            if(id == null)
            {
                return BadRequest();
            }

            var specialTags = await _context.SpecialTags.FindAsync(id);
            if(specialTags == null)
            {
                return BadRequest();
            }
            return View(specialTags);
        }

        public async Task<IActionResult> Delete(int? id) //GET Delete Action Method
        {
            if(id == null)
            {
                return BadRequest();
            }

            var specialTags = await _context.SpecialTags.FindAsync(id);
            if(specialTags == null)
            {
                return BadRequest();
            }
            return View(specialTags);
        }

        [HttpPost] //POST Delete action method
        [ValidateAntiForgeryToken] // security token passed along with the request
        public async Task<IActionResult> Delete(int id)
        {
            var specialTags = await _context.SpecialTags.FindAsync(id);
            _context.Remove(specialTags);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}