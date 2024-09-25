using Duende.IdentityServer.AspNetIdentity;
using Duende.IdentityServer.Models;
using login.Constants;
using login.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace login.Services.Identity;

public class CustomProfileService : ProfileService<ApplicationUser>
{
    public CustomProfileService(UserManager<ApplicationUser> userManager, IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory) : base(userManager, claimsFactory)
    {
    }

    protected override async Task GetProfileDataAsync(ProfileDataRequestContext context, ApplicationUser user)
    {
        var principal = await GetUserClaimsAsync(user);
        var id = (ClaimsIdentity)principal.Identity;

        if (!string.IsNullOrEmpty(user.Firstname))
        {
            id.AddClaim(new Claim(ClaimNameConstants.Firstname, user.Firstname));
        }
        
        if (!string.IsNullOrEmpty(user.Lastname))
        {
            id.AddClaim(new Claim(ClaimNameConstants.Lastname, user.Lastname));
        }

        context.AddRequestedClaims(principal.Claims);
    }
}
