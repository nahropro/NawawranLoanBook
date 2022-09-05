using EntityFrameworkCore.Triggered;
using NLB.Server.Models.Database;

namespace NLB.Server.Data.Triggers
{
    public class TransactionTriggers : IBeforeSaveTrigger<Transaction>
    {
        public Task BeforeSave(ITriggerContext<Transaction> context, CancellationToken cancellationToken)
        {
            if (context.ChangeType == ChangeType.Added)
            {
                context.Entity.CreationDateTime = DateTime.Now;
            }
            else if (context.ChangeType == ChangeType.Modified)
            {
                context.Entity.LastUpdateDateTime = DateTime.Now;
            }

            return Task.CompletedTask;
        }
    }
}
