using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstate.Configurations.Entities;
using RealEstate.Domain;

namespace RealEstate.Data
{
    public class RealEstateContext : DbContext
    {
        public RealEstateContext (DbContextOptions<RealEstateContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstate.Domain.User> User { get; set; } = default!;
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
