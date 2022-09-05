using NLB.Shared.Resources.UserResources;

namespace NLB.Client.Services;

public interface IUserService
{
    Task<bool> LoginAsync(LoginResource login);
    Task LogOutAsync();
    Task LoadTokenAsync();
    Task<SelectUserResource> RegisterUserAsync(CreateUserResource user);
    Task<SelectUserResource> ChangeUserNameAsync(ChangeUserNameResource resource);
    Task<SelectUserResource> ChangePasswordAsync(ChangePasswordResource resource);
}
