using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.ReceiptCommands
{
    [DataContract]
    public class CreateReceiptCommand : ICommand
    {
        public CreateReceiptCommand()
        {
            CommandCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey => Receipt.Id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;

        [DataMember(Order = 2)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = null!;
    }
}
