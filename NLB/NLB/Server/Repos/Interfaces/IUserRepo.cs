using NLB.Server.Models.Database;

namespace NLB.Server.Repos
{
    public interface IUserRepo
    {
        Task<int> CountAsync();
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserAsync(int id);
        Task<User> GetUserAsync(string username);
    }
}