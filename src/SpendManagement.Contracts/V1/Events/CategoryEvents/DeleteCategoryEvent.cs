using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.CategoryEvents
{
    public class DeleteCategoryEvent : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey => Id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
    }
}