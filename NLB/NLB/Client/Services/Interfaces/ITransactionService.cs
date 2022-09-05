using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.TransactionResources;

namespace NLB.Client.Services
{
    public interface ITransactionService
    {
        Task<List<SelectTransactionResource>> GetTransactionsAsync(TransactionQueryResource query = null);
        Task<bool> RemoveTransactionAsync(int transactionId);
        Task<SelectTransactionResource> AddTransactionAsync(UpdateTransactionResource transaction);
        Task<SelectTransactionResource> UpdateCustomerAsync(int transactionId, UpdateTransactionResource transaction);
        Task<SelectTransactionResource> GetTransactionAsync(int transactionId);
    }
}