namespace RealEstate.Domain
{
    public class Company
    {
        public int CompanyId { get; set; }  
        public string CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyPhoneNumber { get; set; }
        public ICollection<Agent> Agents { get; set; } = new List<Agent>();
    }
}
