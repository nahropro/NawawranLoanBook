using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.TransactionResources;

namespace NLB.Client.Services;

public class TransactionService : ITransactionService
{
    private readonly IHttpService httpService;

    public TransactionService(IHttpService httpService)
    {
        this.httpService = httpService;
    }

    public async Task<List<SelectTransactionResource>> GetTransactionsAsync(TransactionQueryResource query = null)
    {
        return await httpService.GetAsync<List<SelectTransactionResource>>("api/transactions", query);
    }

    public async Task<SelectTransactionResource> GetTransactionAsync(int transactionId)
    {
        return await httpService.GetAsync<SelectTransactionResource>($"api/transactions/{transactionId}");
    }

    public async Task<bool> RemoveTransactionAsync(int transactionId)
    {
        return await httpService.DeleteAsync($"api/transactions/{transactionId}");
    }

    public async Task<SelectTransactionResource> AddTransactionAsync(UpdateTransactionResource transaction)
    {
        return await httpService.PostAsync<SelectTransactionResource, UpdateTransactionResource>
            ("api/transactions", transaction);
    }

    public async Task<SelectTransactionResource> UpdateCustomerAsync
        (int transactionId, UpdateTransactionResource transaction)
    {
        return await httpService.PutAsync<SelectTransactionResource, UpdateTransactionResource>
            ($"api/transactions/{transactionId}", transaction);
    }
}
