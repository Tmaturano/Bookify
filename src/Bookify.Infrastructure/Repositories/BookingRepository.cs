using Bookify.Domain.Entities.Apartments;
using Bookify.Domain.Entities.Bookings;
using Bookify.Domain.Entities.Bookings.Enums;
using Bookify.Domain.Entities.Bookings.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Repositories;
internal sealed class BookingRepository : Repository<Booking, BookingId>, IBookingRepository
{
    private static readonly BookingStatus[] ActiveBookingStatuses =
    {
        BookingStatus.Reserved,
        BookingStatus.Confirmed,
        BookingStatus.Completed
    };

    public BookingRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<bool> IsOverlappingAsync(Apartment apartment, DateRange duration, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<Booking>()
            .AnyAsync(booking =>
                        booking.ApartmentId == apartment.Id &&
                        booking.Duration.Start == duration.Start &&
                        booking.Duration.End == duration.End &&
                        ActiveBookingStatuses.Contains(booking.Status),
                    cancellationToken);
    }
}
