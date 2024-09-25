using System.Security.Cryptography.X509Certificates;

namespace login.Extensions;

public static class IdentityServerBuilderExtension
{
    public static IIdentityServerBuilder AddCertificate(this IIdentityServerBuilder serverBuilder, IConfiguration configuration)
    {

        // add certificate
        //serverBuilder.AddDeveloperSigningCredential();

        // add certificate
        var certificatePath = configuration["Login:CertificatePath"];
        var certificatePassword = configuration["Login:CertificatePassword"];

        if (!File.Exists(certificatePath))
        {
            throw new FileNotFoundException("certificate missing in " + certificatePath);
        }

        var certificate = new X509Certificate2(certificatePath, certificatePassword);

        serverBuilder.AddSigningCredential(certificate);

        return serverBuilder;
    }

}