﻿using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Commands.ReceiptCommands
{
    public class DeleteReceiptCommand : ICommand
    {
        [IgnoreDataMember]
        public string RoutingKey => Id.ToString();

        [IgnoreDataMember]
        public DateTime CommandCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
    }
}