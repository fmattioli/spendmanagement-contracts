using SpendManagement.Contracts.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.RecurringReceiptCommands
{
    public struct UpdateRecurringReceiptCommand(RecurringReceipt recurringReceipt) : ICommand
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = recurringReceipt.Id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; } = DateTime.UtcNow;

        [DataMember(Order = 1)]
        public RecurringReceipt RecurringReceipt { get; set; } = recurringReceipt;
    }
}
