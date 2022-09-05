using NLB.Server.Models.Database;
using NLB.Shared.Resources.CustomerResources;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.ReportResources;

namespace NLB.Server.Repos
{
    public interface ICustomerRepo
    {
        Task<Customer> CreateCustomerAsync(Customer customer);
        Task<Customer> GetCustomerAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">Search text</param>
        /// <returns></returns>
        IAsyncEnumerable<SelectCustomerResource> GetCustomersAsync(string? s = null);
        Customer RemoveCustomer(Customer customer);
        Task<LoanReportResource> GetLoanReportAsync(LoanQueryResource query);
        Task<CustomerSummaryReportResource> GetCustomerSummaryReportAsync(int customerId);
    }
}