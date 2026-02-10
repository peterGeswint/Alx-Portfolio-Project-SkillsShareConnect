using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;
using System;

namespace SkillsShareConnect.Controllers
{
    public class LocationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetLatestLocation()
        {
            var latestLocation = _context.Locations.OrderByDescending(l => l.Id).FirstOrDefault();
            if (latestLocation == null)
            {
                return NotFound(new { message = "No location found" });
            }
            return Json(latestLocation);
        }

        [HttpPost]
        public IActionResult SaveLocation([FromBody] Location location)
        {
            if (location == null)
            {
                return BadRequest(new { message = "Invalid location data" });
            }

            _context.Locations.Add(location);
            _context.SaveChanges();

            return Json(new { message = "Location saved successfully", location });
        }
    }

}
