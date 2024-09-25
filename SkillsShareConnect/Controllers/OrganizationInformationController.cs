using Microsoft.AspNetCore.Mvc;

namespace SkillsShareConnect.Controllers
{
    public class OrganizationInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
