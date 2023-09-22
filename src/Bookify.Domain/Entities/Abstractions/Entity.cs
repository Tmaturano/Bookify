namespace Bookify.Domain.Entities.Abstractions;

public abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    protected Entity(Guid id)
    {
        Id = id;
    }

    //EF Migration usage
    protected Entity() { }

    public Guid Id { get; init; }

    public void ClearDomainEvents() => _domainEvents.Clear();
    public IReadOnlyList<IDomainEvent> GetDomainEvents() => _domainEvents;
    protected void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
    
}
