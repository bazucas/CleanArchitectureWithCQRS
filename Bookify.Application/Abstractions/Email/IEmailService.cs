using EmailAddress = Bookify.Domain.Users.Email;

namespace Bookify.Application.Abstractions.Email;

public interface IEmailService
{
    Task SendAsync(EmailAddress recipient, string subject, string body);
}