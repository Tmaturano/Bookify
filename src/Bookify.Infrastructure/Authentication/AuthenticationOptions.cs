namespace Bookify.Infrastructure.Authentication;
public class AuthenticationOptions
{
    public string Audience { get; init; } = string.Empty;
    public string MetadataUrl { get; set; } = string.Empty;
    public bool RequireHttpsMetadata { get; init; }
    public string ValidIssuer { get; set; } = string.Empty;
}
