using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.CategoryCommands
{
    public struct UpdateCategoryCommand(Category category) : ICommand
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = category.Id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; } = DateTime.UtcNow;

        [DataMember(Order = 1)]
        public Category Category { get; set; } = category;
    }
}
