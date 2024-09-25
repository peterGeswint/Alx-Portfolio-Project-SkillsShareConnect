using Microsoft.AspNetCore.Mvc;

namespace SkillsShareConnect.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
