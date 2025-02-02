using Microsoft.AspNetCore.Identity;
using RealEstate.Domain;
using System.Text.Json.Serialization;

namespace RealEstate.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class RealEstateUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public string? DisplayName { get; set; }

        [JsonIgnore] // Prevent recursive serialization
        public IList<Inquiry> UserInquiries { get; set; } = new List<Inquiry>();
        public IList<PropertyTransaction> PropertiesTransactions { get; set; }
    }
}
