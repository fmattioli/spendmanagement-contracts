using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.CategoryEvents
{
    public class CreateCategoryEvent : IEvent
    {
        public CreateCategoryEvent(Category category)
        {
            RoutingKey = category.Id.ToString();
            Category = category;
            EventCreatedDate = category.CreatedDate;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Category Category { get; set; } = null!;
    }
}
