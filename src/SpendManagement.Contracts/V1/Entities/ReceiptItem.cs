namespace SpendManagement.Contracts.V1.Entities
{
    public class ReceiptItem
    {
        public ReceiptItem(Guid id, string itemName, Guid categoryId, short quantity, decimal itemPrice, string observation)
        {
            Id = id;
            ItemName = itemName;
            CategoryId = categoryId;
            Quantity = quantity;
            ItemPrice = itemPrice;
            Observation = observation;
        }

        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public Guid CategoryId { get; set; }
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; }
        public decimal TotalPrice { get { return ItemPrice * Quantity; } }
    }
}
