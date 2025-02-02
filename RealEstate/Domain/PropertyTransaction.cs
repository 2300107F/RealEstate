using RealEstate.Data;

namespace RealEstate.Domain
{
    public class PropertyTransaction
    {
        public int PropertyTransactionId { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        // Navigation Property to User who made purchase
        public string UserId { get; set; }
        public RealEstateUser User { get; set; }

        // Navigation Property to the property that is being purchased
        public Property Property { get; set; }
        public int PropertyId { get; set; }
    }
}
