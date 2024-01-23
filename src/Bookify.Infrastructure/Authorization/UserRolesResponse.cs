using Bookify.Domain.Entities.Users;

namespace Bookify.Infrastructure.Authorization;

public sealed class UserRolesResponse
{
    public Guid Id { get; init; }
    public List<Role> Roles { get; init; } = new List<Role>();
}
