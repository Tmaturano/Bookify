using Bookify.Domain.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure.Repositories;
internal abstract class Repository<TEntity, TEntityId> 
    where TEntity : Entity<TEntityId>
    where TEntityId : class
{
    protected readonly ApplicationDbContext DbContext;

    protected Repository(ApplicationDbContext dbContext) => DbContext = dbContext;

    public async Task<TEntity> GetByIdAsync(TEntityId id, CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<TEntity>()
            .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public virtual void Add(TEntity entity) => DbContext.Add(entity);
}
