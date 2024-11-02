using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Entities;

namespace PurpleBuzz.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<PricingPlan> PricingPlans { get; set; }
    public DbSet<ContactInfo> ContactInfos { get; set; }
    public DbSet<Service> Services { get; set; }

}