using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain;

namespace RealEstate.Configurations.Entities
{
    public class PropertySeed : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasData(
            new Property
            {
                PropertyId = 1,
                Address = "Tampines Blk 123",
                City = "Singapore",
                State = "Singapore",
                PostalCode = "330022",
                Price = 1000000,
                PropertyType = "HDB",
                Bedrooms = 5,
                Bathrooms = 3,
                Sqft = 1100,
                Status = "Available",
                //AgentId = 1, // FK reference to Agent
                RegionId = 1
            },
            new Property
            {
                PropertyId = 2,
                Address = "Bedok Blk 456",
                City = "Singapore",
                State = "Singapore",
                PostalCode = "123456",
                Price = 400000,
                PropertyType = "HDB",
                Bedrooms = 3,
                Bathrooms = 2,
                Sqft = 700,
                Status = "Available",
                //AgentId = 2, // Fk Reference to Agent
                RegionId = 1
            },
            new Property
            {
                PropertyId = 3,
                Address = "Kallang Blk 123",
                City = "Singapore",
                State = "Singapore",
                PostalCode = "364029",
                Price = 750000,
                PropertyType = "HDB",
                Bedrooms = 4,
                Bathrooms = 2,
                Sqft = 890,
                Status = "Sold",
                //AgentId = 1,
                RegionId = 2,
            }
            );
        }
    }
}
