using Bookify.Domain.Entities.Users;

namespace Bookify.Infrastructure.Repositories;
internal sealed class UserRepository : Repository<User, UserId>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public override void Add(User user)
    {
        //This will tell EF Core that any roles present on our user object are already inside of the database and you don't
        //need to insert them again 
        foreach (var role in user.Roles)
        {
            DbContext.Attach(role);
        }

        DbContext.Add(user);
    }
}
