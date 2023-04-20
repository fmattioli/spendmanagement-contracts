using Spents.Contracts.Commands.Interface;
using Spents.Contracts.Documents;

namespace Spents.Domain.Commands
{
    public class CreateReceiptCommand : ICommand
    {
        public CreateReceiptCommand(ReceiptDocument receiptDocument)
        {
            Id = Guid.NewGuid();
            ReceiptDocument = receiptDocument;
        }

        public Guid Id { get; set; }

        public ReceiptDocument ReceiptDocument { get; set; }
    }
}
