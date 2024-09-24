using Duende.IdentityServer.EntityFramework.DbContexts;
using login.Data;
using Microsoft.EntityFrameworkCore;

namespace login.Extensions;

public static class WebApplicationExtensions
{
    public static void ApplyDatabaseMigrations(this WebApplication webApplication)
    {
        using var serviceScope = webApplication.Services.GetService<IServiceScopeFactory>()?.CreateScope();

        serviceScope?.ServiceProvider.GetRequiredService<ConfigurationDbContext>().Database.Migrate();
        serviceScope?.ServiceProvider.GetRequiredService<PersistedGrantDbContext>().Database.Migrate();
        serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>().Database.Migrate();
    }
}