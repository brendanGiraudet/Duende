using Microsoft.AspNetCore.Identity.UI.Services;

namespace login.Services.EmailSender;

public class EmailSender : IEmailSender
{
    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // TODO
        // send email
    }
}
