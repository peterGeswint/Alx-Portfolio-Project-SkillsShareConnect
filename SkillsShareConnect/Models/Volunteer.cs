using SkillsShareConnect.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models;

public partial class Volunteer
{
    [Key]
    public Guid VolunteerId { get; set; }

    public Guid UserId { get; set; }

    public Guid SkillId { get; set; }

    public string? Availability { get; set; }

    public string? Experience { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;

    public virtual ICollection<VolunteerOpportunity> VolunteerOpportunities { get; set; } = new List<VolunteerOpportunity>();

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
