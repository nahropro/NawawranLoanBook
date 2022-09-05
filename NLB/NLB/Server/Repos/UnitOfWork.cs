using NLB.Server.Data;

namespace NLB.Server.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NLBDbContext context;

        public UnitOfWork(NLBDbContext context)
        {
            this.context = context;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}
