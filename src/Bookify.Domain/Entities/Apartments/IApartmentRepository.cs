namespace Bookify.Domain.Entities.Apartments;

public interface IApartmentRepository
{
    Task<Apartment> GetByIdAsync(ApartmentId id, CancellationToken cancellationToken = default);
}
