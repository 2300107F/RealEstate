using Microsoft.AspNetCore.Identity;

namespace RealEstate.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class RealEstateUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
