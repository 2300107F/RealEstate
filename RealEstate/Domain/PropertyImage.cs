namespace RealEstate.Domain
{
    public class PropertyImage
    {
        public int PropertyImageId { get; set; }
        public string FilePath { get; set; }

        // Navigation Property
        public Property Property { get; set; }
        public int PropertyId { get; set; }
    }
}
