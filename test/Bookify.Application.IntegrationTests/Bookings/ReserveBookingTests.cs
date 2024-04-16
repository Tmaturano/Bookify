using Bookify.Application.Bookings.ReserveBooking;
using Bookify.Application.IntegrationTests.Infrastructure;
using Bookify.Domain.Entities.Users;
using FluentAssertions;

namespace Bookify.Application.IntegrationTests.Bookings;
public class ReserveBookingTests : BaseIntegrationTest
{
    private static readonly Guid ApartmentId = Guid.NewGuid();
    private static readonly Guid UserId = Guid.NewGuid();
    private static readonly DateOnly StartDate = new DateOnly(2024, 1, 1);
    private static readonly DateOnly EndDate = new DateOnly(2024, 1, 10);


    public ReserveBookingTests(IntegrationTestWebAppFactory webAppFactory) : base(webAppFactory)
    {
    }

    [Fact]
    public async Task ReserveBooking_ShouldReturnFailure_WhenUserIsNotFound()
    {
        // Arrange
        var command = new ReserveBookingCommand(ApartmentId, UserId, StartDate, EndDate);

        // Act
        var result = await Sender.Send(command);

        // Assert
        result.Error.Should().Be(UserErrors.NotFound);
    }

}
