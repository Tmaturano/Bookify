namespace Bookify.Application.Users.GetLoggedInUser;
public sealed class UserResponse
{
    public Guid Id { get; init; }
    public string Email { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
}
