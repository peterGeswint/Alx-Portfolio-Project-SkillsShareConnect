using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models
{
    public class OrganizationInformation
    {
        [Key]
        public int OrganizationId { get; set; }

        [Required]
        public string OrganizationName { get; set; }

        [Required]
        public string OrganizationEmail { get; set; }

        [Required]
        public string OrganizationDescription { get; set; }

        [Required]
        public string OrganizationType { get; set; }

        [Required]
        public string OrganizationTypeDescription { get; set; }

    }
}
