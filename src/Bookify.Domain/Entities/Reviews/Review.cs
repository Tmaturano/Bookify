using Bookify.Domain.Entities.Abstractions;
using Bookify.Domain.Entities.Bookings;
using Bookify.Domain.Entities.Bookings.Enums;
using Bookify.Domain.Entities.Reviews.Events;
using Bookify.Domain.Entities.Reviews.ValueObjects;
using System.Xml.Linq;

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

    private Review() { }

    public Guid ApartmentId { get; private set; }

    public Guid BookingId { get; private set; }

    public Guid UserId { get; private set; }

    public Rating Rating { get; private set; }

    public string Comment { get; private set; }

    public DateTime CreatedOnUtc { get; private set; }

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
