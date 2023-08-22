using Bookify.Domain.Entities.Abstractions;

namespace Bookify.Domain.Entities.Reviews;

public static class ReviewErrors
{
    public static Error NotEligible = new(
        "Review.NotEligible",
        "The review is not eligible because the booking is not yet completed");
}
