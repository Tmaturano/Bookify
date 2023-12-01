namespace Bookify.Domain.Entities.Users;

public record UserId(Guid Value)
{
    public static UserId New() => new(Guid.NewGuid());
}
