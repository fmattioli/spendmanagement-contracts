namespace Spents.Contracts.V1.Base
{
    public interface IReceipt
    {
        public string EstablishmentName { get; }
        public DateTime ReceiptDate { get; }
        public IEnumerable<ReceiptItem> ReceiptItems { get; }
    }

    public class ReceiptItem
    {
        public ReceiptItem()
        {
            TotalPrice = ItemPrice * Quantity;
        }

        public Guid Id { get; set; }
        public string ItemName { get; set; } = null!;
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; } = null!;
        public decimal TotalPrice { get; set; }
    }
}
