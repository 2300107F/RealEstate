using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Configurations.Entities;
using RealEstate.Data;
using RealEstate.Domain;

namespace RealEstate.Data
{
    public class RealEstateContext(DbContextOptions<RealEstateContext> options) : IdentityDbContext<RealEstateUser>(options)
    {

        public DbSet<RealEstate.Domain.Agent> Agent { get; set; } = default!;
        public DbSet<RealEstate.Domain.Company> Company { get; set; } = default!;
        public DbSet<RealEstate.Domain.Inquiry> Inquiry { get; set; } = default!;
        public DbSet<RealEstate.Domain.PropertyTransaction> PropertyTransaction { get; set; } = default!;
        public DbSet<RealEstate.Domain.Property> Property { get; set; } = default!;
        public DbSet<RealEstate.Domain.PropertyImage> PropertyImage { get; set; } = default!;
        public DbSet<RealEstate.Domain.Region> Region { get; set; } = default!;
        public DbSet<RealEstate.Domain.Facility> Facility { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Configure Inquiry -> RealEstateUser relationship
            builder.Entity<Inquiry>()
                .HasOne(i => i.User)
                .WithMany(u => u.UserInquiries)
                .HasForeignKey(i => i.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete from AspNetUsers to Inquiry

            // Configure Inquiry -> Property relationship (example)
            builder.Entity<Inquiry>()
                .HasOne(i => i.Property)
                .WithMany(p => p.PropertiesInquiries) // or PropertiesInquiries if that’s what you name it
                .HasForeignKey(i => i.PropertyId)
                .OnDelete(DeleteBehavior.Cascade); // Only if this relationship is safe to cascade delete

            builder.Entity<PropertyTransaction>()
                .HasOne(pt => pt.User)             // Assuming 'User' is the navigation property
                .WithMany(u => u.PropertiesTransactions)  // Assuming you have a collection for transactions in your user entity
                .HasForeignKey(pt => pt.UserId)
                .OnDelete(DeleteBehavior.Restrict);  // Use Restrict (or NoAction) instead of Cascade

            builder.ApplyConfiguration(new UserSeed());

            builder.ApplyConfiguration(new CompanySeed());
            builder.ApplyConfiguration(new AgentSeed());

            builder.ApplyConfiguration(new RegionSeed());
            builder.ApplyConfiguration(new FacilitySeed());
            builder.ApplyConfiguration(new PropertySeed());
            builder.ApplyConfiguration(new PropertyTransactionSeed());

        }
    }
}
