namespace Spents.Contracts.V1.Commands.Interfaces
{
    public interface ICommand
    {
        Guid Id { get; }
        DateTime CreateDate { get; }
    }
}
