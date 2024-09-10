using SkillsShareConnect.Areas.Identity.Data;
namespace SkillsShareConnect.Models.ViewModels
{
    public class VolunteerRequest
    {
        public Guid UserId { get; set; }

        public string? Skills { get; set; }

        public string? Availability { get; set; }

        public string? Experience { get; set; }

        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<VolunteerOpportunity> VolunteerOpportunities { get; set; } = new List<VolunteerOpportunity>();
    }
}
