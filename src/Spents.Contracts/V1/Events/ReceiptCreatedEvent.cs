using Spents.Contracts.V1.Base;
using Spents.Contracts.V1.Events.Interfaces;

using System.Runtime.Serialization;

namespace Spents.Contracts.V1.Events
{
    public class ReceiptCreatedEvent : IReceipt, IEvent
    {
        public ReceiptCreatedEvent(Guid receiptId, DateTime receiptDate, string establishmentName, IEnumerable<ReceiptItem> receiptItems)
        {
            this.Id = receiptId;
            this.CreatedDate = DateTime.UtcNow;
            this.ReceiptDate = receiptDate;
            this.EstablishmentName = establishmentName;
            this.ReceiptItems = receiptItems;
        }

        [IgnoreDataMember]
        public Guid Id { get; }
        [DataMember(Order = 1)]
        public DateTime CreatedDate { get; }
        [DataMember(Order = 2)]
        public string EstablishmentName { get; }
        [DataMember(Order = 3)]
        public DateTime ReceiptDate { get; }
        [DataMember(Order = 4)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; }
        [DataMember(Order = 5)]
        public DateTime CreateDate { get; }
    }
}
