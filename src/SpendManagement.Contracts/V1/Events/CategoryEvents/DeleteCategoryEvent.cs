using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.CategoryEvents
{
    public class DeleteCategoryEvent : IEvent
    {
        public DeleteCategoryEvent(string routingKey, Guid id)
        {
            RoutingKey = routingKey;
            Id = id;
            EventCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
    }
}