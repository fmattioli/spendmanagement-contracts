﻿using SpendManagement.Contracts.V1.Base;
using SpendManagement.Contracts.V1.Entities;
using SpendManagement.Contracts.V1.Events.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events
{
    public class CreatedReceiptEvent : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey => Receipt.Id.ToString();

        public DateTime EventCreatedDate {get; set;}

        [DataMember(Order = 1)]
        public Receipt Receipt { get; set; } = null!;

        [DataMember(Order = 2)]
        public IEnumerable<ReceiptItem> ReceiptItem { get; set; } = null!;
    }
}
