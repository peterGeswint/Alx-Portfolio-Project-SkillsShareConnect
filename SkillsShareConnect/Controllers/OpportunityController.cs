using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillsShareConnect.Areas.Identity.Data;
using SkillsShareConnect.Models;

namespace SkillsShareConnect.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;

        public OpportunityController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Address address)
        {
            // Ensure the model state is valid
            if (ModelState.IsValid)
            {
                // Set the User field to the currently logged-in user
                var currentUser = await userManager.GetUserAsync(User);
                address.User = currentUser.Id;

                // Add the address to the database
                dbContext.Addresses.Add(address);
                await dbContext.SaveChangesAsync();

                // Redirect to a different action after successful submission
                return RedirectToAction("Index", "Home"); // Adjust as necessary
            }

            // If the model state is invalid, return the same view with the model data
            return View(address);
        }
    }
}

