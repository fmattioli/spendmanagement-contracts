using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.CategoryCommands
{
    public class DeleteCategoryCommand : ICommand
    {
        public DeleteCategoryCommand(Guid id)
        {
            CommandCreatedDate = DateTime.UtcNow;
            RoutingKey = id.ToString();
            Id = id;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
    }
}
