using Bookify.Domain.Entities.Apartments;
using Bookify.Domain.Entities.Apartments.ValueObjects;
using Bookify.Domain.Shared;

namespace Bookify.Domain.UnitTests.Apartments;
internal static class ApartmentData
{
    public static Apartment Create(Money price, Money? cleaningFee = null) => new(
        ApartmentId.New(),
        "Test Apartment",
        "Test Description",
        new Address("Country", "State", "ZipCode", "City", "Street"),
        price,
        cleaningFee ?? Money.Zero(),
        []);
}
 