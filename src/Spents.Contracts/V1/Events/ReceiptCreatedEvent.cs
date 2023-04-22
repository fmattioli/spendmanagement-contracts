using Spents.Contracts.V1.Base;
using Spents.Contracts.V1.Events.Interfaces;
using System.Runtime.Serialization;

namespace Spents.Contracts.V1.Events
{
    public class ReceiptCreatedEvent
    {
        public ReceiptCreatedEvent(Guid receiptId, DateTime receiptDate, string establishmentName, IEnumerable<ReceiptItem> receiptItems)
        {
            this.Id = receiptId;
            this.CreatedDate = DateTime.UtcNow;
            this.ReceiptDate = receiptDate;
            this.EstablishmentName = establishmentName;
            this.ReceiptItems = receiptItems;
        }


        [DataMember(Order = 1)]
        public Guid Id { get; }
        [DataMember(Order = 2)]
        public DateTime CreatedDate { get; }
        [DataMember(Order = 3)]
        public string EstablishmentName { get; }
        [DataMember(Order = 4)]
        public DateTime ReceiptDate { get; }
        [DataMember(Order = 5)]
        public DateTime CreateDate { get; }
        [DataMember(Order = 6)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; }
    }
}
