using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models.ViewModels
{
    public class VolunteerOpportunityRequest
    {

        [Key]
        public Guid OpportunityId { get; set; }

        public string Title { get; set; } = null!;

        public string Status { get; set; }

        public string Opportunity { get; set; }

        public string? Description { get; set; }

        public string? Location { get; set; }

        public string? RequiredSkills { get; set; }

        public DateTime DatePosted { get; set; }

        public Guid OrganizationId { get; set; }

        public Volunteer Volunteer { get; set; }

        public Organization? Organization { get; set; }
    }
}
