using System.ComponentModel.DataAnnotations;
using SkillsShareConnect.Areas.Identity.Data;

namespace SkillsShareConnect.Models.ViewModels
{
    public class OpportunityRequest
    {

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public string? Location { get; set; }

        public string? RequiredSkills { get; set; }

        public DateTime DatePosted { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<VolunteerOpportunity> VolunteerOpportunities { get; set; } = new List<VolunteerOpportunity>();
    }
}
