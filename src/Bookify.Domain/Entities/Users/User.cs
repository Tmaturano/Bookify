using Bookify.Domain.Entities.Abstractions;
using Bookify.Domain.Entities.Users.Events;
using Bookify.Domain.Entities.Users.ValueObjects;

namespace Bookify.Domain.Entities.Users;

public sealed class User : Entity
{
    private User(Guid id, string firstName, string lastName, Email email) 
        : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    private User() { }

    public string IdentityId { get; private set; } = string.Empty;
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Email Email { get; private set; }

    public static User Create(string firstName, string lastName, Email email)
    {
        var user = new User(Guid.NewGuid(), firstName, lastName, email);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }

    public void SetIdentityId(string identityId) => IdentityId = identityId;
}
