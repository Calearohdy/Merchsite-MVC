using System;
using System.Linq;
using System.Threading.Tasks;
using MerchWebsite.Data;
using MerchWebsite.Models;
using MerchWebsite.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MerchWebsite.Areas.Customer.Controllers
{
    [Authorize(Roles = SD.AdminEndUser)]
    [Area("Admin")]
    public class AdminUsersController : Controller
    {
        private readonly ApplicationDbContext context;
        private int PageSize = 4;
        public AdminUsersController(ApplicationDbContext context)
        {
            this.context = context;

        }

        public IActionResult Index(int userPage = 1)
        {
            return View(context.ShoppingUser.ToList());
        }

        public async Task<IActionResult> Edit(string id) // id is passed as a guid
        {
            if(id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }

            var user = await context.ShoppingUser.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, ShoppingUser shoppingUser)
        {
            if(id != shoppingUser.Id)
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                ShoppingUser user = context.ShoppingUser.Where(u => u.Id == id).FirstOrDefault();
                user.Name = shoppingUser.Name;
                user.UserName = shoppingUser.UserName;
                user.Email = shoppingUser.Email;

                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(shoppingUser);
        }

        public async Task<IActionResult> Delete(string id) // id is passed as a guid
        {
            if(id == null || id.Trim().Length == 0)
            {
                return NotFound();
            }

            var user = await context.ShoppingUser.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUser(string id)
        {
                ShoppingUser user = context.ShoppingUser.Where(u => u.Id == id).FirstOrDefault();
                user.LockoutEnd = DateTime.Now.AddYears(1000);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
        }
    }
}