﻿using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.RecurringReceiptEvents
{
    public struct DeleteRecurringReceiptCommand(Guid id) : IEvent
    {
        [IgnoreDataMember]
        public string RoutingKey { get; set; } = id.ToString();

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; } = DateTime.UtcNow;

        [DataMember(Order = 1)]
        public Guid Id { get; set; } = id;
    }
}
