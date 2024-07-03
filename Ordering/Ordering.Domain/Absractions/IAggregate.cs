namespace Ordering.Domain.Absractions
{
    public interface IAggregate : IEntity
    {
        IReadOnlyList<IDomainEvent> DomainEvents { get; }
        IDomainEvent[] ClearDomainEvents();
    }
    public interface IAggregate<T> : IAggregate, IEntity<T>
    {

    }
}
