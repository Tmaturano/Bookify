using Bookify.Domain.Entities.Abstractions;

namespace Bookify.Domain.Entities.Bookings;

public static class BookingErrors
{
    public static readonly Error NotFound = new(
        "Booking.NotFound",
        "The booking with the specified identifier was not found");

    public static readonly Error Overlap = new(
        "Booking.Overlap",
        "The current booking is overlaping with an existing one");

    public static readonly Error NotReserved = new(
        "Booking.NotReserved",
        "The booking is not pending");

    public static readonly Error NotConfirmed = new(
        "Booking.NotConfirmed",
        "The booking is not confirmed");

    public static readonly Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "The booking has already started");
}
