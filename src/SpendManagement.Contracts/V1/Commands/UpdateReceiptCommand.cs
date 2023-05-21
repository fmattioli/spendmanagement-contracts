using SpendManagement.Contracts.V1.Base;
using SpendManagement.Contracts.V1.Commands.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands
{
    public class UpdateReceiptCommand : ICommand
    {
        public UpdateReceiptCommand()
        {
            CommandCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey => Receipt.Id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;
    }
}
