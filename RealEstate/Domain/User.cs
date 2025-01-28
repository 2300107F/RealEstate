using System.Text.Json.Serialization;

namespace RealEstate.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? UserPhoneNumber { get; set; }
        public DateTime DateRegistered { get; set; }

        [JsonIgnore] // Prevent recursive serialization
        public ICollection<Inquiry> UserInquiries { get; set; } = new List<Inquiry>();
    }
}
