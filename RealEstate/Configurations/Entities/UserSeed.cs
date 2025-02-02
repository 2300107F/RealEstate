using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using RealEstate.Data;
using RealEstate.Domain;
using System.Drawing;

namespace RealEstate.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<RealEstateUser>
    {
        public void Configure(EntityTypeBuilder<RealEstateUser> builder)
        {
            var hasher = new PasswordHasher<RealEstateUser>();
            builder.HasData(
            new RealEstateUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );

        }
    }
}
