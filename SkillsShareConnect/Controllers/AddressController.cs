using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;
using SkillsShareConnect.Models;
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

        [HttpGet]
        public IActionResult Index()
        {
            var addresses = applicationDbContext.Addresses.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddressRequest addressRequest)
        {
            if (ModelState.IsValid)
            {
                // Save the address to the database by mapping the address request to the address model and then saving it to the database.
                var newAddress = new Address
                {
                    Location = addressRequest.Location,
                    Apartment = addressRequest.Apartment,
                    City = addressRequest.City,
                    Province = addressRequest.Province,
                    PostalCode = addressRequest.PostalCode,
                    Country = addressRequest.Country
                };
                applicationDbContext.Addresses.Add(newAddress);
                applicationDbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(addressRequest);
        }
    }
}
