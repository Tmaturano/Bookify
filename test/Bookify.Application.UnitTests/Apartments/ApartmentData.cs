using Bookify.Domain.Entities.Apartments;
using Bookify.Domain.Entities.Apartments.ValueObjects;
using Bookify.Domain.Shared;

namespace Bookify.Application.UnitTests.Apartments;
internal static class ApartmentData
{
    public static Apartment Create() => new(
        ApartmentId.New(),
        "Test Apartment",
        "Test Description",
        new Address("Country", "State", "ZipCode", "City", "Street"),
        new Money(100.0m, Currency.Usd),
        Money.Zero(),
        []);
}
