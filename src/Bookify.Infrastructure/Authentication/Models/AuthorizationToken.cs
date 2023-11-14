using System.Text.Json.Serialization;

namespace Bookify.Infrastructure.Authentication.Models;

/// <summary>
/// To Authentication to the Key Cloak Admin API
/// </summary>
public sealed class AuthorizationToken
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; init; } = string.Empty;
}
