using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using RealEstate.Data;
using System.Reflection;

namespace RealEstate.Domain
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AgentPhoneNumber { get; set; }
        public string LicenseNumber { get; set; }

        public string UserId { get; set; }
        public RealEstateUser User { get; set; }

        // Navigation Property
        public Company Company { get; set; }
        public int CompanyId { get; set; }

        public ICollection<Property> AgentProperties { get; set; } = new List<Property>();

    }
}
