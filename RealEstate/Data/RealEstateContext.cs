using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Configurations.Entities;

namespace RealEstate.Data
{
    public class RealEstateContext(DbContextOptions<RealEstateContext> options) : IdentityDbContext<RealEstateUser>(options)
    {
        
        public DbSet<RealEstate.Domain.User> User { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
    

}
