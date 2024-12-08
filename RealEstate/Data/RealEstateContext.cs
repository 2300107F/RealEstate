using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;

namespace RealEstate.Data
{
    public class RealEstateContext(DbContextOptions<RealEstateContext> options) : IdentityDbContext<RealEstateUser>(options)
    {
        public DbSet<RealEstate.Domain.User> User { get; set; } = default!;
    }

    
}
