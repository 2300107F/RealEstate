using RealEstate.Data;
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
        public string UserId { get; set; }
        public RealEstateUser User { get; set; }

        [JsonIgnore] // Prevent recursive serialization
        public Property? Property { get; set; }
        public int PropertyId { get; set; }
    }
}
