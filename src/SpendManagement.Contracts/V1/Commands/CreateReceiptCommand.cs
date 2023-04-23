using SpendManagement.Contracts.V1.Base;
using SpendManagement.Contracts.V1.Commands.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands
{
    [DataContract]
    public class CreateReceiptCommand : IReceipt, ICommand
    {
        public CreateReceiptCommand()
        {
            CommandCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey => Id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }

        [DataMember(Order = 2)]
        public DateTime ReceiptDate { get; set; }

        [DataMember(Order = 3)]
        public string EstablishmentName { get; set; } = null!;

        [DataMember(Order = 4)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = null!;
    }
}
