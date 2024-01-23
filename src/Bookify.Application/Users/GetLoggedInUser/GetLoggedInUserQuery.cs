using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Users.GetLoggedInUser;
public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;
