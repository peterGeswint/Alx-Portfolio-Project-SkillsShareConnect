using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;

namespace SkillsShareConnect.Controllers
{
    public class SkillController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public SkillController(ApplicationDbContext dbContext)
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
