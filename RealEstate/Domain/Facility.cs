namespace RealEstate.Domain
{
    public class Facility
    {
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string? FacilityDescription { get; set; }
        
        // Navigation Property
        public Region Region { get; set; }
        public int RegionId { get; set; }
    }
}
