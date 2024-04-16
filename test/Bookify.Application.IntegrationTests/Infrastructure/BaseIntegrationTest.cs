using Bookify.Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Application.IntegrationTests.Infrastructure;
public abstract class BaseIntegrationTest : IClassFixture<IntegrationTestWebAppFactory>
{
    private readonly IServiceScope _serviceScope; // Resolve any scoped services.

    protected readonly ISender Sender; // To Send commands and queries to run the integration tests
    protected readonly ApplicationDbContext DbContext; // Used to write any assertions

    protected BaseIntegrationTest(IntegrationTestWebAppFactory webAppFactory)
    {
        _serviceScope = webAppFactory.Services.CreateScope();

        Sender = _serviceScope.ServiceProvider.GetRequiredService<ISender>();
        DbContext = _serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    }
}
