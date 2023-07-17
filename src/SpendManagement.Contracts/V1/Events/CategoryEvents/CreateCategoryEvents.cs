using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.CategoryEvents
{
    public class CreateCategoryEvents : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey => Category.Id.ToString();

        public DateTime EventCreatedDate { get; set; }

        public Category Category { get; set; } = null!;
    }
}
