namespace SpendManagement.Contracts.V1.Interfaces
{
    public interface IEvent
    {
        string RoutingKey { get; set; }
        DateTime EventCreatedDate { get; }
    }
}
