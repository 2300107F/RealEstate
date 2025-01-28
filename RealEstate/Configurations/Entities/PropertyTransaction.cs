using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain;
using System.Transactions;

namespace RealEstate.Configurations.Entities
{
    public class PropertyTransactionSeed : IEntityTypeConfiguration<PropertyTransaction>
    {
        public void Configure(EntityTypeBuilder<PropertyTransaction> builder)
        {
            builder.HasData(
            new PropertyTransaction
            {
                PropertyTransactionId = 1,
                Amount = 800000,
                TransactionDate = DateTime.Now,
                UserId = 1,
                PropertyId = 3,

            }
            );
        }
    }
}
