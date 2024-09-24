using login.Services.EmailSender;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace login.Extensions;

public static class ServiceCollections
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IEmailSender, EmailSender>();
    }
}
