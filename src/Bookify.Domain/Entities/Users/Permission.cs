namespace Bookify.Domain.Entities.Users;
public sealed class Permission
{
    public static readonly Permission UsersRead = new(1, "users:read");

    public Permission(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}
