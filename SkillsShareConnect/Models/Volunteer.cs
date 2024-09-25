using SkillsShareConnect.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models;

public partial class Volunteer
{
    [Key]
    public Guid VolunteerId { get; set; }

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

    //Other Information

    public string? Availability { get; set; }

    public string? Experience { get; set; }

    public virtual ICollection<VolunteerOpportunity> VolunteerOpportunities { get; set; } = new List<VolunteerOpportunity>();

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
