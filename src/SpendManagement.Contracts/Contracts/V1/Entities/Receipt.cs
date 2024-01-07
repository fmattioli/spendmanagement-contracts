namespace SpendManagement.Contracts.V1.Entities
{
    public class Receipt
    {
        public Receipt(Guid id, Guid categoryId, string establishmentName, DateTime receiptDate)
        {
            Id = id;
            CategoryId = categoryId;
            EstablishmentName = establishmentName;
            ReceiptDate = receiptDate;
        }

        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string EstablishmentName { get; set; }
        public DateTime ReceiptDate { get; set; }

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
