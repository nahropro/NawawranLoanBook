using AutoMapper;
using NLB.Server.Models.Database;
using NLB.Server.Repos;
using NLB.Shared.Resources.UserResources;

namespace NLB.Server.Services;

public class UserService : IUserService
{
    private readonly IUserRepo userRepo;
    private readonly IHashService hashService;
    private readonly IMapper mapper;

    public UserService(IUserRepo userRepo, IHashService hashService, IMapper mapper)
    {
        this.userRepo = userRepo;
        this.hashService = hashService;
        this.mapper = mapper;
    }

    public async Task<int> CountAsync()
    {
        return await userRepo.CountAsync();
    }

    public async Task<User> RegisterUserAsync(CreateUserResource resource)
    {
        var user = mapper.Map<User>(resource);

        var hash = hashService.GenerateHash(resource.Password);

        user.PasswordHash = hash.PasswordHash;
        user.Salt = hash.Salt;

        return await userRepo.CreateUserAsync(user);
    }

    public async Task<User> CheckCredentialsAsync(LoginResource resource)
    {
        var user = await userRepo.GetUserAsync(resource.UserName);

        if(user == null)
            return null;

        if (!hashService.CheckPassword(resource.Password, user.Salt, user.PasswordHash))
            return null;

        return user;
    }

    public async Task<User> ChangeUserNameAsync(int userId, ChangeUserNameResource resource)
    {
        var user = await userRepo.GetUserAsync(userId);

        if (user == null)
            return null;

        if (!hashService.CheckPassword(resource.Password, user.Salt, user.PasswordHash))
            return null;

        user.UserName = resource.UserName;

        return user;
    }

    public async Task<User> ChangePasswordAsync(int userId, ChangePasswordResource resource)
    {
        var user = await userRepo.GetUserAsync(userId);

        if (user == null)
            return null;

        if (!hashService.CheckPassword(resource.OldPassword, user.Salt, user.PasswordHash))
            return null;

        var hash = hashService.GenerateHash(resource.NewPassword);

        user.PasswordHash = hash.PasswordHash;
        user.Salt = hash.Salt;

        return user;
    }
}
