using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace NLB.Server.Extensions;

public static class ControllerBaseExtensions
{
    public static int GetUserId(this ControllerBase controller)
    {
        //Get the user id form jwt token claims
        return int.Parse(controller.User.Claims
            .SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value);
    }
}
