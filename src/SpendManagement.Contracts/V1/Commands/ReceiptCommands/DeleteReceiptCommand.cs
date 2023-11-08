using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.ReceiptCommands
{
    public class DeleteReceiptCommand : ICommand
    {
        public DeleteReceiptCommand(Guid receiptId)
        {
            CommandCreatedDate = DateTime.UtcNow;
            RoutingKey = receiptId.ToString();
            Id = receiptId;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
    }
}
