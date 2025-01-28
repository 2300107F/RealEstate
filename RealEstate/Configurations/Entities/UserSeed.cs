using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using RealEstate.Domain;
using System.Drawing;

namespace RealEstate.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
            new User
            {
                UserId = 1,
                UserName = "John",
                Email = "JohnDoe@gmail.com",
                Password = "P@ssword1",
                UserPhoneNumber = "12345678",
                DateRegistered = DateTime.Now,
            },
            new User
            {
                UserId = 2,
                UserName = "Samantha",
                Email = "Samantha@gmail.com",
                Password = "P@ssword1",
                UserPhoneNumber = "11111111",
                DateRegistered = DateTime.Now,
            }
            );

        }
    }
}
