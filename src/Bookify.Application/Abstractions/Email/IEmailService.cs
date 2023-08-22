namespace Bookify.Application.Abstractions.Email;

public interface IEmailService
{
    Task SendAsync(Domain.Entities.Users.ValueObjects.Email recipient, string subject, string body);
}
