using Bookify.Domain.Entities.Abstractions;

namespace Bookify.Domain.UnitTests;

public abstract class BaseTest
{
    public static T AssertDomainEventWasPublished<T>(IEntity entity)
        where T : IDomainEvent
    {
        var domainEvent = entity.GetDomainEvents().OfType<T>().SingleOrDefault();

        if (domainEvent == null)
        {
            throw new Exception($"{typeof(T).Name} was not published");
        }

        return domainEvent;
    }
}