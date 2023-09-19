using Bookify.Domain.Entities.Apartments;
using Bookify.Domain.Entities.Bookings;
using Bookify.Domain.Entities.Reviews;
using Bookify.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookify.Infrastructure.Configurations;
internal sealed class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("reviews");

        builder.HasKey(x => x.Id);

        builder.OwnsOne(x => x.Rating);

        builder.Property(x => x.Comment)
            .HasMaxLength(200);

        builder.HasOne<Apartment>()
            .WithMany()
            .HasForeignKey(x => x.ApartmentId);

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(x => x.UserId);

        builder.HasOne<Booking>()
            .WithMany()
            .HasForeignKey(x => x.BookingId);
    }
}
