namespace Spents.Contracts.V1.Base
{
    public interface IReceipt
    {
        public Guid Id { get; set; }
        public string EstablishmentName { get; set; }
        public DateTime ReceiptDate { get; set; }
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; }
    }

    public class ReceiptItem
    {
        public Guid Id { get; set; }
        public string ItemName { get; set; } = null!;
        public short Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public string Observation { get; set; } = null!;
        public decimal TotalPrice { get { return ItemPrice * Quantity; } }
    }
}
