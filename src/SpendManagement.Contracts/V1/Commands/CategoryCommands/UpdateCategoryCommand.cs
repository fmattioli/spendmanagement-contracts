using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : ICommand
    {
        public UpdateCategoryCommand(string routingKey, Category category)
        {
            RoutingKey = routingKey;
            CommandCreatedDate = DateTime.UtcNow;
            Category = category;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Category Category { get; set; } = null!;
    }
}
