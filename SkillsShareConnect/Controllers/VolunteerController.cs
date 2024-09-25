using Microsoft.AspNetCore.Mvc;
using SkillsShareConnect.Areas.Identity.Data;
using SkillsShareConnect.Models;
using SkillsShareConnect.Models.ViewModels;

namespace SkillsShareConnect.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public VolunteerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            // Create a new VolunteerOpportunityRequest model
            var model = new VolunteerRequest
            {
                Skill = dbContext.Skills.ToList() // Fetch skills from the database
            };

            return View(model); // Pass the model to the view
        }

        [HttpPost]
        public async Task<IActionResult> Add(VolunteerRequest volunteerRequest)
        {
            

            if (ModelState.IsValid)
            {

                var volunteer = new Volunteer
                {
                    FirstName = volunteerRequest.FirstName,
                    LastName = volunteerRequest.LastName,
                    Email = volunteerRequest.Email,
                    PhoneNumber = volunteerRequest.PhoneNumber,
                    HighestGradePassed = volunteerRequest.HighestGradePassed,
                   CurrentlyStudying = volunteerRequest.CurrentlyStudying,
                    UniversityName = volunteerRequest.UniversityName,
                    FieldOfStudy = volunteerRequest.FieldOfStudy,
                    DateGraduating = volunteerRequest.DateGraduating,
                    Skills = volunteerRequest.Skill,
                    Availability = volunteerRequest.Availability,
                    Experience = volunteerRequest.Experience
                };

                dbContext.Volunteers.Add(volunteer);
                dbContext.SaveChanges();

                return RedirectToAction("Add", "Address");
            }
            volunteerRequest.Skill = dbContext.Skills.ToList();
            return View(volunteerRequest);
        }


    }
}
