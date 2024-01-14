namespace SpendManagement.Contracts.V1.Entities
{
    public class ReceiptItem(Guid id, string itemName, short quantity, decimal itemPrice, string observation, decimal itemDiscount)
    {
        public Guid Id { get; set; } = id;
        public string ItemName { get; set; } = itemName;
        public short Quantity { get; set; } = quantity;
        public decimal ItemPrice { get; set; } = itemPrice;
        public string Observation { get; set; } = observation;
        public decimal TotalPrice { get { return ItemPrice * Quantity; } }
        public decimal ItemDiscount { get; set; } = itemDiscount;
    }
}
