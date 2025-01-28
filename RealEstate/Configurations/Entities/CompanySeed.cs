using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain;

namespace RealEstate.Configurations.Entities
{
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
            new Company
            {
                CompanyId = 1,
                CompanyName = "XYZ realestate",
                CompanyAddress = "Queenstown Road",
                CompanyPhoneNumber = "55555555"
            },
            new Company
            {
                CompanyId = 2,
                CompanyName = "ABC Real Estate",
                CompanyAddress = "Orchard Road",
                CompanyPhoneNumber = "55554444"
            }

            );
           
        }
    }
}
