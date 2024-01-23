using Bookify.Application.Abstractions.Authentication;
using Microsoft.AspNetCore.Http;

namespace Bookify.Infrastructure.Authentication;
internal sealed class UserContext : IUserContext
{
    private readonly IHttpContextAccessor _contextAccessor;

    public UserContext(IHttpContextAccessor contextAccessor) => _contextAccessor = contextAccessor;

    public string IdentityId =>
        _contextAccessor
            .HttpContext?.User
            .GetIdentityId() ?? throw new ApplicationException("User context is unavailable");
}
