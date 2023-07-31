using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.ReceiptEvents
{
    public class DeleteReceiptEvent : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey => Category.Id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Category Category { get; set; } = null!;
    }
}
