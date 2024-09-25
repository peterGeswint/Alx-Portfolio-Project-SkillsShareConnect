namespace SkillsShareConnect.Models.ViewModels
{
    public class SkillRequest
    {

        public string Name { get; set; } = null!;

        public string? ShortDescription { get; set; }

        public string VolunteerId { get; set; } = null!;    

        public virtual Volunteer Volunteer { get; set; } = null!;
    }
}
