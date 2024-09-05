using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models;

public partial class VolunteerOpportunity
{
    [Key]
    public Guid VolunteerId { get; set; }

    public Guid OpportunityId { get; set; }

    public string Status { get; set; } = null!;

    public virtual Opportunity Opportunity { get; set; } = null!;

    public virtual Volunteer Volunteer { get; set; } = null!;
}
