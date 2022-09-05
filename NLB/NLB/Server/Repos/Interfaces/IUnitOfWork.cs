
namespace NLB.Server.Repos
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}