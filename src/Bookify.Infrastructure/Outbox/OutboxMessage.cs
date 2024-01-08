namespace Bookify.Infrastructure.Outbox;
public sealed class OutboxMessage
{
    public OutboxMessage(Guid id, DateTime ocurredOnUtc, string type, string content)
    {
        Id = id;
        OcurredOnUtc = ocurredOnUtc;
        Type = type;
        Content = content;
    }

    public Guid Id { get; private set; }
    public DateTime OcurredOnUtc { get; private set; }
    
    /// <summary>
    /// Name of the Domain Event
    /// </summary>
    public string Type { get; private set; }

    /// <summary>
    /// JSON string containing the serialized domain event
    /// </summary>
    public string Content { get; private set; }
    public DateTime? ProcessedOnUtc { get; private set; }
    public string Error { get; private set; }
}
