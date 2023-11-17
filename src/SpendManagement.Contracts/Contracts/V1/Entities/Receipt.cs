namespace SpendManagement.Contracts.V1.Entities
{
    public class Receipt
    {
        public Receipt(Guid id, string establishmentName, DateTime receiptDate)
        {
            Id = id;
            EstablishmentName = establishmentName;
            ReceiptDate = receiptDate;
        }

        public Guid Id { get; set; }
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
