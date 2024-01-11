using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.ReceiptEvents
{
    public struct UpdateReceiptEvent(Receipt receipt, IEnumerable<ReceiptItem> receiptItems) : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = receipt.Id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; } = DateTime.UtcNow;

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = receipt;

        [DataMember(Order = 2)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = receiptItems;
    }
}
