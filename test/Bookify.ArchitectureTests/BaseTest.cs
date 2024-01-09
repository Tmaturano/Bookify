using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Entities.Abstractions;
using Bookify.Infrastructure;
using System.Reflection;

namespace Bookify.ArchitectureTests;

public abstract class BaseTest
{
    protected static Assembly ApplicationAssembly => typeof(IBaseCommand).Assembly;

    protected static Assembly DomainAssembly => typeof(IEntity).Assembly;

    protected static Assembly InfrastructureAssembly => typeof(ApplicationDbContext).Assembly;
}