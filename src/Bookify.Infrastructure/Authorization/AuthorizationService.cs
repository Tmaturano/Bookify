using Bookify.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Authorization;
internal sealed class AuthorizationService
{
    private readonly ApplicationDbContext _context;

    public AuthorizationService(ApplicationDbContext context) => _context = context;

    public async Task<UserRolesResponse> GetRolesForUserAsync(string identityId)
    {
        var roles = await _context.Set<User>()
            .Where(user => user.IdentityId == identityId)
            .Select(user => new UserRolesResponse
            {
                Id = user.Id.Value,
                Roles = user.Roles.ToList()
            })
            .FirstAsync();

        return roles;
    }
}
