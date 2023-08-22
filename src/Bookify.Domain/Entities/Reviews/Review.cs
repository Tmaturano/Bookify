using Bookify.Domain.Entities.Abstractions;
using Bookify.Domain.Entities.Bookings;
using Bookify.Domain.Entities.Bookings.Enums;
using Bookify.Domain.Entities.Reviews.Events;
using Bookify.Domain.Entities.Reviews.ValueObjects;

namespace Bookify.Domain.Entities.Reviews;

public class Review : Entity
{
    private Review(
        Guid id,
        Guid apartmentId,
        Guid bookingId,
        Guid userId,
        Rating rating,
        string comment,
        DateTime createdOnUtc) : base(id)
    {
        ApartmentId = apartmentId;
        BookingId = bookingId;
        UserId = userId;
        Rating = rating;
        Comment = comment;
        CreatedOnUtc = createdOnUtc;
    }

    public Guid ApartmentId { get; }
    public Guid BookingId { get; }
    public Guid UserId { get; }
    public Rating Rating { get; }
    public string Comment { get; }
    public DateTime CreatedOnUtc { get; }

    public static Result<Review> Create(
        Booking booking,
        Rating rating,
        string comment,
        DateTime createdOnUtc)
    {
        if (booking.Status != BookingStatus.Completed)
            return Result.Failure<Review>(ReviewErrors.NotEligible);

        var review = new Review(
            Guid.NewGuid(),
            booking.ApartmentId,
            booking.Id,
            booking.UserId,
            rating,
            comment,
            createdOnUtc);

        review.RaiseDomainEvent(new ReviewCreatedDomainEvent(review.Id));

        return review;
    }
}
