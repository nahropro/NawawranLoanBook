using NLB.Server.Models.Database;
using NLB.Shared.Resources.UserResources;

namespace NLB.Server.Services
{
    public interface ITokenService
    {
        TokenResource GenerateJwtToken(User user, int expireAfterDays = 30);
    }
}