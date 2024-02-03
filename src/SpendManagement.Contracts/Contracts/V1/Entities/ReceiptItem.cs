namespace SpendManagement.Contracts.V1.Entities
{
    public class ReceiptItem
    {
        public ReceiptItem(Guid id, string itemName, short quantity, decimal itemPrice, string observation, decimal itemDiscount)
        {
            Id = id;
            ItemName = itemName;
            Quantity = quantity;
            ItemPrice = itemPrice;
            Observation = observation;
            ItemDiscount = itemDiscount;
            TotalPrice = CalculateTotalPrice();
        }

        public Guid Id { get; set; }
        public string ItemName { get; set; }
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal TotalPrice { get; private set; }

        private decimal CalculateTotalPrice()
        {
            return (Quantity* ItemPrice) - ItemDiscount;
        }
    }
}
