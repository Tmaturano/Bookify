namespace Bookify.Infrastructure.Outbox;

/// <summary>
/// Used for background jobs to process the messages
/// </summary>
public sealed class OutboxOptions
{
    public int IntervalInSeconds { get; init; }

    /// <summary>
    /// The number of outbox messages that we are processing in one run of the background job
    /// </summary>
    public int BatchSize { get; init; }
}
