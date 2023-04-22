namespace Spents.Contracts.V1.Events.Interfaces
{
    public interface IEvent
    {
        public Guid Id { get;}
        public DateTime CreatedDate { get; }
    }
}
