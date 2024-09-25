using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models.ViewModels
{
    public class AddressRequest
    {

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

    }
}
