using Bookify.Domain.Entities.Apartments;
using Bookify.Domain.Entities.Apartments.Enums;
using Bookify.Domain.Entities.Bookings.ValueObjects;
using Bookify.Domain.Shared;

namespace Bookify.Domain.Entities.Bookings;

public class PricingService
{
    public PricingDetails CalculatePrice(Apartment apartment, DateRange period)
    {
        var currency = apartment.Price.Currency;

        var priceForPeriod = new Money(apartment.Price.Amount * period.LengthInDays, currency);

        decimal percentageUpCharge = 0;
        foreach (var amenity in apartment.Amenities)
        {
            percentageUpCharge += amenity switch
            {
                Amenity.GardenView or Amenity.MountainView => 0.05m,
                Amenity.AirConditioning => 0.01m,
                Amenity.Parking => 0.01m,
                _ => 0
            };
        }

        var amenitiesUpCharge = Money.Zero(currency);
        if (percentageUpCharge > 0)        
            amenitiesUpCharge = new Money(priceForPeriod.Amount * percentageUpCharge, currency);

        var totalPrice = Money.Zero(currency);
        totalPrice += priceForPeriod;

        if (!apartment.CleaningFee.IsZero())
            totalPrice += apartment.CleaningFee;

        totalPrice += amenitiesUpCharge;

        return new PricingDetails(priceForPeriod, apartment.CleaningFee, amenitiesUpCharge, totalPrice);        
    }
}
