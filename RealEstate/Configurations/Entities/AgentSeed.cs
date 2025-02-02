using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.Domain;

namespace RealEstate.Configurations.Entities
{
    public class AgentSeed : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
           //builder.HasData(
           //new Agent
           //{
           //    AgentId = 1,
           //    Name = "Lawrence Tan",
           //    Email = "LawrenceTan@gmail.com",
           //    Password = "P@ssword1",
           //    AgentPhoneNumber = "54326789",
           //    LicenseNumber = "S123456",
           //    CompanyId = 1
           //},
           //new Agent
           //{
           //    AgentId = 2,
           //    Name = "Jonas Lim",
           //    Email = "JonasLim@realestateagent.com",
           //    Password = "P@ssword1",
           //    AgentPhoneNumber = "87003840",
           //    LicenseNumber = "T246802",
           //    CompanyId = 1
           //}
           //);
        }
    }
}
