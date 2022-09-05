using NLB.Server.Models.Database;
using NLB.Shared.Resources.UserResources;

namespace NLB.Server.Services
{
    public interface IUserService
    {
        Task<int> CountAsync();
        Task<User> RegisterUserAsync(CreateUserResource resource);
        Task<User> CheckCredentialsAsync(LoginResource resource);
        Task<User> ChangeUserNameAsync(int userId, ChangeUserNameResource resource);
        Task<User> ChangePasswordAsync(int userId, ChangePasswordResource resource);
    }
}