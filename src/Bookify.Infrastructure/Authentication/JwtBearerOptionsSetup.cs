using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

namespace Bookify.Infrastructure.Authentication;
public class JwtBearerOptionsSetup : IConfigureNamedOptions<JwtBearerOptions>
{
    private readonly AuthenticationOptions _options;

    public JwtBearerOptionsSetup(IOptions<AuthenticationOptions> options) => _options = options.Value;

    public void Configure(string name, JwtBearerOptions options) => Configure(options);

    public void Configure(JwtBearerOptions options)
    {
        options.Audience = _options.Audience;
        options.MetadataAddress = _options.MetadataUrl;
        options.RequireHttpsMetadata = _options.RequireHttpsMetadata;
        options.TokenValidationParameters.ValidIssuer = _options.ValidIssuer;
    }
}
