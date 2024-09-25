using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SkillsShareConnect.Areas.Identity.Data;
using SkillsShareConnect.Models;

namespace SkillsShareConnect.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Assigning role id to user
        var adminRoleId = "3b6c5c71-ec54-40d2-8633-366021c5f128";
        var organizationRoleId = "685e8f72-53aa-41f0-8312-68493272346f";
        var userRoleId = "68cc202d-ec90-477e-8332-e66e812b7eab";

        // Seed roles
        var roles = new List<IdentityRole>
        {
             new IdentityRole
            {
                Name ="admin",
                NormalizedName = "ADMIN",
                Id = adminRoleId,
                ConcurrencyStamp = adminRoleId ,
            },

            new IdentityRole
            {
                Name = "Organization",
                NormalizedName = "ORGANIZATION",
                Id = organizationRoleId,
                ConcurrencyStamp = organizationRoleId,
            },

             new IdentityRole
            {
               Name = "User",
               NormalizedName = "User",
               Id = userRoleId,
               ConcurrencyStamp = userRoleId
            }




        };

        builder.Entity<IdentityRole>().HasData(roles);

        // Adding an admin user
        var adminUserId = "3952d38f-2c3f-4ebc-a8cb-8834b1023cb6";
        var adminUser = new ApplicationUser
        {
            UserName = "admin@skillshareConnect.org",
            Email = "admin@skillshareConnect.org",
            NormalizedUserName = "admin@skillshareConnect.org".ToUpper(),
            NormalizedEmail = "admin@skillshareConnect.org".ToUpper(),
            Id = adminUserId
        };

        adminUser.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(adminUser, "Admin@123");

        builder.Entity<ApplicationUser>().HasData(adminUser);


        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }


    public DbSet<Opportunity> Oppertunities { get; set; }
    public DbSet<Volunteer> Volunteers { get; set; }
    public DbSet<VolunteerOpportunity> VolunteerOpportunities { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<OrganizationInformation> Organizations { get; set; }
    public DbSet<Address> Addresses { get; set; }


}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

    }
}
