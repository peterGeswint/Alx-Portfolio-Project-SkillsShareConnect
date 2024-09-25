using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;
using SkillsShareConnect.Models.ViewModels;

namespace SkillsShareConnect.Controllers
{
    public class AddressController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AddressController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddressRequest address)
        {
            if (ModelState.IsValid)
            {
                // Save the address to the database
                return RedirectToAction("Index");
            }
            return View(address);
        }
    }
}
