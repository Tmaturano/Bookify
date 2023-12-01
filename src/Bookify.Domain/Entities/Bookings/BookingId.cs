namespace Bookify.Domain.Entities.Bookings;

public record BookingId(Guid Value)
{
    public static BookingId New() => new(Guid.NewGuid());
}
