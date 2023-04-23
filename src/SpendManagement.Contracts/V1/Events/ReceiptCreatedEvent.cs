using SpendManagement.Contracts.V1.Base;
using SpendManagement.Contracts.V1.Events.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events
{
    public class ReceiptCreatedEvent : IReceipt, IEvent
    {
        public ReceiptCreatedEvent()
        {
            EventCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey => Id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate {get; set;}

        [DataMember(Order = 1)]
        public Guid Id { get; set; }

        [DataMember(Order = 2)]
        public string EstablishmentName { get; set; } = null!;

        [DataMember(Order = 3)]
        public DateTime ReceiptDate { get; set; }

        [DataMember(Order = 4)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = null!;
    }
}
