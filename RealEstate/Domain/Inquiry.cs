using System.Text.Json.Serialization;

namespace RealEstate.Domain
{
    public class Inquiry
    {
        public int InquiryId { get; set; }
        public DateTime DateOfInquiry { get; set; }
        public string? Message { get; set; }
        public string? Status { get; set; }

        //Navigation Property
        [JsonIgnore] // Prevent recursive serialization
        public User User { get; set; }
        public int UserId { get; set; }

        [JsonIgnore] // Prevent recursive serialization
        public Property? Property { get; set; }
        public int PropertyId { get; set; }
    }
}
