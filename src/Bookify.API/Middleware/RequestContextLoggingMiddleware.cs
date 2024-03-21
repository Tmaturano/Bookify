using Serilog.Context;

namespace Bookify.API.Middleware;

/// <summary>
/// Middleware to give the flexibility of either taking in the correlation id externally from another service talking
/// with my API allowing me to trace a single request across multiple services in a microservice environment
/// </summary>
public class RequestContextLoggingMiddleware
{
    private const string CorrelationIdHeaderName = "X-Correlation-Id";
    private readonly RequestDelegate _next;

    public RequestContextLoggingMiddleware(RequestDelegate requestDelegate) => _next = requestDelegate;

    public Task Invoke(HttpContext context)
    {
        using (LogContext.PushProperty("CorrelationId", GetCorrelationId(context)))
        {
            return _next(context);
        }
    }

    private static string GetCorrelationId(HttpContext context)
    {
        context.Request.Headers.TryGetValue(CorrelationIdHeaderName, out var correlationId);

        return correlationId.FirstOrDefault() ?? context.TraceIdentifier;
    }
}
