using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.ReceiptEvents
{
    public class UpdateReceiptEvent : IEvent
    {
        public UpdateReceiptEvent(Receipt receipt, IEnumerable<ReceiptItem> receiptItems)
        {
            RoutingKey = receipt.Id.ToString();
            Receipt = receipt;
            ReceiptItems = receiptItems;
            EventCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;

        [DataMember(Order = 2)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = null!;
    }
}
