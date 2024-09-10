using SkillsShareConnect.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models;

public partial class Opportunity
{
    [Key]
    public Guid OpportunityId { get; set; }

    public Guid UserId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string? RequiredSkills { get; set; }

    public DateTime DatePosted { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;

    public virtual ICollection<VolunteerOpportunity> VolunteerOpportunities { get; set; } = new List<VolunteerOpportunity>();
}
