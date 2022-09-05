using Microsoft.EntityFrameworkCore;
using NLB.Server.Data;
using NLB.Server.Models.Database;

namespace NLB.Server.Repos;

public class UserRepo : IUserRepo
{
    private readonly NLBDbContext context;

    public UserRepo(NLBDbContext context)
    {
        this.context = context;
    }

    public async Task<int> CountAsync()
    {
        return await context.Users.CountAsync();
    }

    public async Task<User> GetUserAsync(string username)
    {
        return await context.Users.SingleOrDefaultAsync(x => x.UserName == username);
    }

    public async Task<User> GetUserAsync(int id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<User> CreateUserAsync(User user)
    {
        await context.Users.AddAsync(user);
        return user;
    }
}
