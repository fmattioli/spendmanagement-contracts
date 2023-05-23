using SpendManagement.Contracts.V1.Base;
using SpendManagement.Contracts.V1.Events.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events
{
    public class UpdateReceiptEvent : IEvent
    {
        public UpdateReceiptEvent()
        {
            EventCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey => Receipt.Id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;

    }
}
