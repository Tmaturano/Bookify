namespace Bookify.Domain.Entities.Users;

public interface IUserRepository
{
    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    void Add(User user);
}
