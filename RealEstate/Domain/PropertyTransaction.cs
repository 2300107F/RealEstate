namespace RealEstate.Domain
{
    public class PropertyTransaction
    {
        public int PropertyTransactionId { get; set; }
        public int Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        // Navigation Property
        public User User { get; set; }
        public int UserId { get; set; }
        public Property Property { get; set; }
        public int PropertyId { get; set; }
    }
}
