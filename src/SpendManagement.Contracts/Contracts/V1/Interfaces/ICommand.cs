namespace SpendManagement.Contracts.V1.Interfaces
{
    public interface ICommand
    {
        string RoutingKey { get; }
        DateTime CommandCreatedDate { get; }
    }
}
