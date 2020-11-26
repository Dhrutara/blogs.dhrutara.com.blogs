using EFCoreInheritance.Domain;
using EFCoreInheritance.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreInheritance.TablePerType
{
    public class PolicyTemplateDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public PolicyTemplateDbContext(DbContextOptions<PolicyTemplateDbContext> dbContextOptions) : base(dbContextOptions)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<OrganizationPolicyTemplate> OrganizationPolicyTemplates { get; set; }
        public DbSet<RegionPolicyTemplate> RegionPolicyTemplates { get; set; }
        public DbSet<CountryPolicyTemplate> CountryPolicyTemplates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizationPolicyTemplate>().ToTable("OrganizationPolicyTemplate");
            modelBuilder.Entity<RegionPolicyTemplate>().ToTable("RegionPolicyTemplate");
            modelBuilder.Entity<CountryPolicyTemplate>().ToTable("CountryPolicyTemplate");
        }
    }
}
