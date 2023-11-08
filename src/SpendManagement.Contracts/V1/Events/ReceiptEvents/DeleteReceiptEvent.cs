﻿using SpendManagement.Contracts.V1.Interfaces;
using System.Runtime.Serialization;

namespace SpendManagement.Contracts.V1.Events.ReceiptEvents
{
    public class DeleteReceiptEvent : IEvent
    {
        public DeleteReceiptEvent(Guid receiptId)
        {
            RoutingKey = receiptId.ToString();
            Id = receiptId;
            EventCreatedDate = DateTime.UtcNow;
        }

        [IgnoreDataMember]
        public string RoutingKey { get; set; }

        [IgnoreDataMember]
        public DateTime EventCreatedDate { get; set; }

        [DataMember(Order = 1)]
        public Guid Id { get; set; }
    }
}
