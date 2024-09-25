using SkillsShareConnect.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SkillsShareConnect.Models.ViewModels
{
    public class VolunteerRequest
    {

        //Personal Information
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        // Education information
        [Required]
        [DisplayName("Highest Grade Passed")]
        public string HighestGradePassed { get; set; }

        [Required]
        [DisplayName("Current Status")]
        public string CurrentlyStudying { get; set; }

        [Required]
        [DisplayName("University Name")]
        public string UniversityName { get; set; }

        [Required]
        public string FieldOfStudy { get; set; }

        [Required]
        public DateTime DateGraduating { get; set; } = DateTime.Now;

        //Employment Information
        [Required]
        [ForeignKey(nameof(Skill))]
        public string? SelectedSkills { get; set; }

        public ICollection<Skill> Skill { get; set; } = new List<Skill>();

        [Required]
        public string? Availability { get; set; }

        [Required]
        public string? Experience { get; set; }

        
        public virtual ApplicationUser User { get; set; } = null!;

        public virtual ICollection<VolunteerOpportunity> VolunteerOpportunities { get; set; } = new List<VolunteerOpportunity>();
    }
}
