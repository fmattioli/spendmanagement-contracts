using Spents.Contracts.V1.Base;
using Spents.Contracts.V1.Commands.Interfaces;
using System.Runtime.Serialization;

namespace Spents.Contracts.V1.Commands
{
    [DataContract]
    public class CreateReceiptCommand : IReceipt, ICommand
    {
        public CreateReceiptCommand(Guid receiptId, DateTime receiptDate, string establishmentName, IEnumerable<ReceiptItem> receiptItems)
        {
            Id = receiptId;
            CreateDate = DateTime.UtcNow;
            ReceiptDate = receiptDate;
            EstablishmentName = establishmentName;
            ReceiptItems = receiptItems;
        }

        [IgnoreDataMember]
        public Guid Id { get; }
        [DataMember(Order = 1)]
        public DateTime CreatedDate { get; }
        [DataMember(Order = 2)]
        public string EstablishmentName { get; }
        [DataMember(Order = 3)]
        public DateTime ReceiptDate { get; }
        [DataMember(Order = 4)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; }
        [DataMember(Order = 5)]
        public DateTime CreateDate { get; }
    }
}
