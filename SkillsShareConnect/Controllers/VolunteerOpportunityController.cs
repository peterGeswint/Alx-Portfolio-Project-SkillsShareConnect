using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;

namespace SkillsShareConnect.Controllers
{
    public class VolunteerOpportunityController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public VolunteerOpportunityController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
