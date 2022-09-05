using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NLB.Server.Data;
using NLB.Server.Models.Database;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.TransactionResources;

namespace NLB.Server.Repos;

public class TransactionRepo : ITransactionRepo
{
    private readonly NLBDbContext context;
    private readonly IMapper mapper;

    public TransactionRepo(NLBDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public async Task<Transaction> CreateTransactionAsync(Transaction transaction)
    {
        await context.Transactions.AddAsync(transaction);
        return transaction;
    }

    public async Task<Transaction> GetTransactionAsync(int id)
    {
        return await context.Transactions.Include(x=> x.Customer)
            .SingleOrDefaultAsync(x=> x.Id==id);
    }

    public IAsyncEnumerable<SelectTransactionResource> GetTransactionsAsync(TransactionQueryResource query)
    {
        var transactions = context.Transactions.AsQueryable().AsNoTracking();

        if (query.Id.HasValue)
            transactions = transactions.Where(x => x.Id == query.Id.Value);
        else
            transactions = transactions.Where(x =>
                (query.CustomerId.HasValue ? x.CustomerId == query.CustomerId.Value : true) &&
                (query.StartDate.HasValue ? x.Date >= query.StartDate.Value : true) &&
                (query.EndDate.HasValue ? x.Date <= query.EndDate.Value : true) &&
                (query.MoneyInOrOut.HasValue ? x.MoneyInOrOut == query.MoneyInOrOut.Value : true)
            );

        return transactions.ProjectTo<SelectTransactionResource>(mapper.ConfigurationProvider)
            .AsAsyncEnumerable();
    }

    public Transaction RemoveTransaction(Transaction transaction)
    {
        context.Transactions.Remove(transaction);
        return transaction;
    }
}
