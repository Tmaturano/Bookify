using Bookify.Domain.Shared;

namespace Bookify.Domain.Entities.Bookings.ValueObjects;

public record PricingDetails(Money PriceForPeriod, Money CleaningFee, Money AmenitiesUpCharge, Money TotalPrice);
