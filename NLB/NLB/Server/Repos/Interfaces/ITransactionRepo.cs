using NLB.Server.Models.Database;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.TransactionResources;

namespace NLB.Server.Repos
{
    public interface ITransactionRepo
    {
        Task<Transaction> CreateTransactionAsync(Transaction transaction);
        Task<Transaction> GetTransactionAsync(int id);
        IAsyncEnumerable<SelectTransactionResource> GetTransactionsAsync(TransactionQueryResource query);
        Transaction RemoveTransaction(Transaction transaction);
    }
}