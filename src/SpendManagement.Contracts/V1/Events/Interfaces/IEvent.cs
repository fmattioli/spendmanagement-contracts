namespace SpendManagement.Contracts.V1.Events.Interfaces
{
    public interface IEvent
    {
        string RoutingKey { get; }
        DateTime EventCreatedDate { get; }
    }
}
