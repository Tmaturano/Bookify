using Bookify.Domain.Entities.Users;
using Bookify.Domain.Entities.Users.Events;
using Bookify.Domain.Entities.Users.ValueObjects;
using FluentAssertions;

namespace Bookify.Domain.UnitTests.Users;
public class UserTests : BaseTest
{
    [Fact]
    public void Create_Should_Raise_UserCreatedDomainEvent()
    {
        //Arrange
        var firstName = "first";
        var lastName = "last";
        var email = new Email("test@test.com");

        //Act
        var user = User.Create(firstName, lastName, email);

        //Assert
        var userCreatedDomainEvent = AssertDomainEventWasPublished<UserCreatedDomainEvent>(user);

        userCreatedDomainEvent.UserId.Should().Be(user.Id);
    }
}
