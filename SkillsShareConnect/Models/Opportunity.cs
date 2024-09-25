using SkillsShareConnect.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models;

public partial class Opportunity
{
    [Key]
    public Guid OpportunityId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string? RequiredSkills { get; set; }

    public DateTime DatePosted { get; set; }

    public Guid OrganizationId { get; set; }
    public OrganizationInformation? Organization { get; set; }
}
