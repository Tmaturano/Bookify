using Bookify.Domain.Entities.Users;
using Bookify.Domain.Entities.Users.Events;
using FluentAssertions;

namespace Bookify.Domain.UnitTests.Users;
public class UserTests : BaseTest
{
    [Fact]
    public void Create_Should_Raise_UserCreatedDomainEvent()
    {
        //Act
        var user = User.Create(UserData.FirstName, UserData.LastName, UserData.Email);

        //Assert
        var userCreatedDomainEvent = AssertDomainEventWasPublished<UserCreatedDomainEvent>(user);

        userCreatedDomainEvent.UserId.Should().Be(user.Id);
    }


    [Fact]
    public void Create_Should_AddRegisteredRoleToUser()
    {
        //Act
        var user = User.Create(UserData.FirstName, UserData.LastName, UserData.Email);

        //Assert
        user.Roles.Should().Contain(Role.Registered);
    }
}
