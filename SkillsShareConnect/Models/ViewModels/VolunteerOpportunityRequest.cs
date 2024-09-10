using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models.ViewModels
{
    public class VolunteerOpportunityRequest
    {
        [Key]
        public Guid VolunteerId { get; set; }

        public Guid OpportunityId { get; set; }

        public string Status { get; set; } = null!;

        public virtual Opportunity Opportunity { get; set; } = null!;

        public virtual Volunteer Volunteer { get; set; } = null!;
    }
}
