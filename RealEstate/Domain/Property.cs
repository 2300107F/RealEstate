using System.Text.Json.Serialization;

namespace RealEstate.Domain
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public int Price { get; set; }
        public string? PropertyType { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
        public int Sqft { get; set; }
        public string? Status { get; set; }

        // Navigation Property 
        public Agent? Agent { get; set; }
        public int AgentId { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }

       
        public List<Inquiry> PropertiesInquiries { get; set; }

        
        public ICollection<PropertyImage> PropertyImages { get; set; }
    }
}