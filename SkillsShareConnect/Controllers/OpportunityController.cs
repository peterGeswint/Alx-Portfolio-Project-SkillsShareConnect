using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;

namespace SkillsShareConnect.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public OpportunityController(ApplicationDbContext dbContext)
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
