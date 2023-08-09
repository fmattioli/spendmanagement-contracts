using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.CategoryCommands
{
    public class CreateCategoryCommand : ICommand
    {
        public CreateCategoryCommand(string routingKey, Category category)
        {
            CommandCreatedDate = DateTime.UtcNow;
            RoutingKey = routingKey;
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
