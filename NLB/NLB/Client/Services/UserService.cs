using Blazored.LocalStorage;
using NLB.Client.Core;
using NLB.Shared.Resources.UserResources;

namespace NLB.Client.Services;

public class UserService : IUserService
{
    private readonly IHttpService httpService;
    private readonly ILocalStorageService localStorage;
    private const string tokenStorageKey = "token";

    public UserService(IHttpService httpService, ILocalStorageService localStorage)
    {
        this.httpService = httpService;
        this.localStorage = localStorage;
    }

    public async Task<bool> LoginAsync(LoginResource login)
    {
        var token = await httpService.PostAsync<TokenResource, LoginResource>("api/usermanager/login", login);

        if (token is null)
            return false;
        
        await localStorage.SetItemAsync(tokenStorageKey, token);
        Storage.Token = token;

        return true;
    }

    public async Task LogOutAsync()
    {
        await localStorage.RemoveItemAsync(tokenStorageKey);
        Storage.Token = null;
    }

    public async Task LoadTokenAsync()
    {
        try
        {
            Storage.Token = await localStorage.GetItemAsync<TokenResource>(tokenStorageKey);
        }
        catch (Exception)
        {
        }
    }

    public async Task<SelectUserResource> RegisterUserAsync(CreateUserResource user)
    {
        return await httpService.PostAsync<SelectUserResource, CreateUserResource>("api/setup", user);
    }

    public async Task<SelectUserResource> ChangeUserNameAsync(ChangeUserNameResource resource)
    {
        return await httpService.PostAsync<SelectUserResource, ChangeUserNameResource>
            ("api/UserManager/ChangeUserName", resource);
    }

    public async Task<SelectUserResource> ChangePasswordAsync(ChangePasswordResource resource)
    {
        return await httpService.PostAsync<SelectUserResource, ChangePasswordResource>
            ("api/UserManager/ChangePassword", resource);
    }
}
