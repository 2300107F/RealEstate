namespace RealEstate.Domain
{
    public class Region
    {
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string? RegionDescription { get; set; }
        public ICollection<Facility> Facilities { get; set; } = new List<Facility>();
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
