﻿using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.ReceiptCommands
{
    [DataContract]
    public class CreateReceiptCommand : ICommand
    {
        public CreateReceiptCommand(Receipt receipt, IEnumerable<ReceiptItem> receiptItems)
        {
            CommandCreatedDate = DateTime.UtcNow;
            RoutingKey = receipt.Id.ToString();
            Receipt = receipt;
            ReceiptItems = receiptItems;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;

        [DataMember(Order = 2)]
        public IEnumerable<ReceiptItem> ReceiptItems { get; set; } = null!;
    }
}
