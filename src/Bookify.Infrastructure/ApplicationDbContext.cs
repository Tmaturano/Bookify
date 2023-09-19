using Bookify.Domain.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure;
internal sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {        
    }
}
