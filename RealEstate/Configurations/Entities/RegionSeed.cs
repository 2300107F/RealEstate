using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain;

namespace RealEstate.Configurations.Entities
{
    public class RegionSeed : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData(
                new Region
                {
                    RegionId = 1,
                    RegionName = "East",
                    RegionDescription = "Located on the east side of singapore"
                },
                new Region
                {
                    RegionId = 2,
                    RegionName = "Central",
                    RegionDescription = "The Singapore Central Region with towns like toa payoh"
                }
                );
        }
    }
}
