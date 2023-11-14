namespace Bookify.Infrastructure.Authentication.Models;
public sealed class CredentialRepresentationModel
{
    public string Value { get; set; }
    public bool Temporary { get; set; }
    public string Type { get; set; }
}
