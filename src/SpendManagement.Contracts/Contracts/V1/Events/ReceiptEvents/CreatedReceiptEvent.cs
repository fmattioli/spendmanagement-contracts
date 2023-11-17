using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.ReceiptEvents
{
    public class CreatedReceiptEvent : IEvent
    {
        public CreatedReceiptEvent(Receipt receipt, IEnumerable<ReceiptItem> receiptItem)
        {
            RoutingKey = receipt.Id.ToString();
            Receipt = receipt;
            ReceiptItem = receiptItem;
            EventCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;

        [DataMember(Order = 2)]
        public IEnumerable<ReceiptItem> ReceiptItem { get; set; } = null!;
    }
}
