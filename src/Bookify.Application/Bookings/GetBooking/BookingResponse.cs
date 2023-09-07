namespace Bookify.Application.Bookings.GetBooking;
public sealed class BookingResponse
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public Guid ApartmentId { get; init; }
    public int Status { get; init; }
    public decimal PriceAmount { get; init; }
    public string PriceCurrency { get; init; }
    public decimal CleaningFeeAmount { get; init; }
    public string CleaningFeeCurrency { get; init; }
    public decimal AmenitiesUpChargeAmount { get; init; }
    public string AmenitiesUpChargeCurrency { get; init; }
    public decimal TotalPriceAmount { get; init; }
    public string TotalPriceCurrency { get; init; }
    public DateOnly DurationStart { get; init; }
    public DateOnly DurationEnd { get; init; }
    public DateTime CreatedOnUtc { get; init; }
}
