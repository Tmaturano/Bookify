using Bookify.Domain.Entities.Abstractions;

namespace Bookify.Domain.Entities.Users.Events;

public sealed record UserCreatedDomainEvent(UserId UserId) : IDomainEvent;
