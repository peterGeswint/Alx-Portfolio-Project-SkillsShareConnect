using SkillsShareConnect.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillsShareConnect.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [DisplayName("Apartment/ unit/ suit or floor")]
        public string Apartment { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [ForeignKey(nameof(applicationUser))]
        public String User { get; set; }

        
        public ApplicationUser applicationUser { get; set; }
    }
}
