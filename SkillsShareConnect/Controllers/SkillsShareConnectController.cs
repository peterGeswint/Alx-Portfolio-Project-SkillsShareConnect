using Microsoft.AspNetCore.Mvc;

namespace SkillsShareConnect.Controllers
{
	public class SkillsShareConnectController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
