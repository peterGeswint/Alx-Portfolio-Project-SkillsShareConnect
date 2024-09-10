using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsShareConnect.Models;

public partial class Skill
{
    [Key]
    public Guid SkillId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
}
