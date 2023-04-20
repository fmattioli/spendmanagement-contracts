using System.Runtime.Serialization;

namespace Spents.Contracts.Documents
{
    public class ReceiptDocument
    {
        [DataMember]
        public virtual Guid Id { get; set; }

        [DataMember]
        public virtual string EstablishmentName { get; set; } = null!;

        [DataMember]
        public virtual DateTime ReceiptDate { get; set; }

        [DataMember]
        public virtual IEnumerable<ReceiptItem> ReceiptItems { get; set; } = new List<ReceiptItem>();
    }

    public record ReceiptItem
    {
        public virtual Guid Id { get; set; }
        public virtual string ItemName { get; set; } = null!;
        public virtual short Quantity { get; set; }
        public virtual decimal ItemPrice { get; set; }
        public virtual string Observation { get; set; } = null!;
        public virtual decimal TotalPrice { get; set; }
    }
}
