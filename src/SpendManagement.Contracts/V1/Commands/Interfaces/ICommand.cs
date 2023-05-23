namespace SpendManagement.Contracts.V1.Commands.Interfaces
{
    public interface ICommand
    {
        string RoutingKey { get;}
        DateTime CommandCreatedDate { get; }
    }
}
