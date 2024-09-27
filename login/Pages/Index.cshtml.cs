// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace login.Pages.Home;

[AllowAnonymous]
public class Index : PageModel
{
    private readonly IConfiguration _configuration;
    public Index(
        IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Version
    {
        get => _configuration["ApplicationVersion"];
    }
}
