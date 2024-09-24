using login.Services.EmailSender;
using login.Settings;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace login.Extensions;

public static class ServiceCollections
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IEmailSender, EmailSender>();
    }

    public static void AddSettings(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<FeatureSettings>(configuration.GetSection("FeatureSettings"));
    }
}
