namespace Bookify.Domain.Entities.Bookings.ValueObjects;

public record DateRange
{
    private DateRange()
    {
    }

    public DateOnly Start { get; init; }
    public DateOnly End { get; init; }

    public int LengthInDays => End.DayNumber - Start.DayNumber;

    public static DateRange Create(DateOnly start,  DateOnly end)
    {
        if (start > end)
            throw new InvalidOperationException("End date precedes start date");

        return new DateRange
        {
            Start = start,
            End = end
        };
    }
}
