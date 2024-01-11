using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.CategoryCommands
{
    public struct DeleteCategoryCommand(Guid id) : ICommand
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; } = DateTime.UtcNow;

        [DataMember(Order = 1)]
        public Guid Id { get; set; } = id;
    }
}
