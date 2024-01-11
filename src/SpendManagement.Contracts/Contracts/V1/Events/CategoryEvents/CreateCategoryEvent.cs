using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.CategoryEvents
{
    public struct CreateCategoryEvent(Category category) : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = category.Id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; } = category.CreatedDate;

        [DataMember(Order = 1)]
        public Category Category { get; set; } = category;
    }
}
