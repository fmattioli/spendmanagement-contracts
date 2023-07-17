namespace SpendManagement.Contracts.V1.Interfaces
{
    public interface IEvent
    {
        string RoutingKey { get; }
        DateTime EventCreatedDate { get; }
    }
}
