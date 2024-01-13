namespace SpendManagement.Contracts.V1.Entities
{
    public class Receipt(Guid id, Guid categoryId, string establishmentName, DateTime receiptDate)
    {
        public Guid Id { get; set; } = id;
        public Guid CategoryId { get; set; } = categoryId;
        public string EstablishmentName { get; set; } = establishmentName;
        public DateTime ReceiptDate { get; set; } = receiptDate;
        public decimal Total { get; set; }
        public decimal Discount { get; set; }

        public bool Validate()
        {
            if (!string.IsNullOrEmpty(EstablishmentName)
                && ReceiptDate.Date != DateTime.MinValue
                && Id != Guid.Empty)
            {
                return true;
            }

            return false;
        }
    }
}
