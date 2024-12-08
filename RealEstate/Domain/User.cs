namespace RealEstate.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name{ get; set; }
        public string? Email { get; set; }
        public string? Password{ get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateRegistered { get; set; }
        public string? UserType { get; set; }


    }
}
