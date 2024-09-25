using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models.ViewModels
{
    public class VolunteerOpportunityRequest
    {

        public string Status { get; set; } = null!;

        public virtual Opportunity Opportunity { get; set; } = null!;

        public virtual Volunteer Volunteer { get; set; } = null!;
    }
}
