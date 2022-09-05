using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using NLB.Server.Data;
using NLB.Server.Models.Database;
using NLB.Shared.Resources.CustomerResources;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.ReportResources;

namespace NLB.Server.Repos;

public class CustomerRepo : ICustomerRepo
{
    private readonly NLBDbContext context;
    private readonly IMapper mapper;

    public CustomerRepo(NLBDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        await context.Customers.AddAsync(customer);
        return customer;
    }

    public async Task<Customer> GetCustomerAsync(int id)
    {
        return await context.Customers.Include(x=> x.Transactions).SingleOrDefaultAsync(x=> x.Id==id);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="s">Search text</param>
    /// <returns></returns>
    public IAsyncEnumerable<SelectCustomerResource> GetCustomersAsync(string? s = null)
    {
        var customers = context.Customers.AsQueryable().AsNoTracking();

        if(!string.IsNullOrEmpty(s))
            customers=customers.Where(x=> x.FullName.Contains(s) || x.Phone.Contains(s)
            || x.Id.ToString()==s);

        return customers.ProjectTo<SelectCustomerResource>(mapper.ConfigurationProvider)
            .AsAsyncEnumerable();
    }

    public Customer RemoveCustomer(Customer customer)
    {
        context.Customers.Remove(customer);
        return customer;
    }

    public async Task<LoanReportResource> GetLoanReportAsync(LoanQueryResource query)
    {
        var result = new LoanReportResource();
        result.LoanQuery = query;

        var customers=context.Customers.AsNoTracking();

        var selectedCustomers = customers.ProjectTo<SelectCustomerResource>(mapper.ConfigurationProvider).Where(x =>
            x.Balance!= 0 &&
            (query.CreditorOrDebter.HasValue? (query.CreditorOrDebter.Value?x.Balance<0: x.Balance>0): true) &&
            (query.BalanceStart.HasValue? Math.Abs(x.Balance.GetValueOrDefault()) >= query.BalanceStart.Value: true) &&
            (query.BalanceEnd.HasValue? Math.Abs(x.Balance.GetValueOrDefault()) <= query.BalanceEnd.Value :true)
          );

        result.Loans = await selectedCustomers.ToListAsync();

        return result;
    }

    public async Task<CustomerSummaryReportResource> GetCustomerSummaryReportAsync(int customerId)
    {
        var result=new CustomerSummaryReportResource();

        var customer= await context.Customers.Include(x=> x.Transactions)
            .AsNoTracking().SingleOrDefaultAsync(x=> x.Id==customerId);

        if (customer is null)
            return null;

        result.Customer = mapper.Map<SelectCustomerResource>(customer);
        result.CustomerSummaryDetails = 
            mapper.Map<IEnumerable<CustomerSummaryDetail>>(customer.Transactions.OrderBy(x => x.Date).ToList());

        //Calculate balance-in-time
        decimal balanceInTime = 0;
        foreach (var d in result.CustomerSummaryDetails)
        {
            balanceInTime += (d.Amount + d.DiscountAmount) * (d.MoneyInOrOut ? -1 : 1);
            d.BalanceInTime = balanceInTime;
        }

        return result;
    }
}
