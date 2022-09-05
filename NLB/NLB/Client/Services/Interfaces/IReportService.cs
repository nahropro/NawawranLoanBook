using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.ReportResources;

namespace NLB.Client.Services;

public interface IReportService
{
    Task<LoanReportResource> GetLoanAsync(LoanQueryResource query = null);
    Task<CustomerSummaryReportResource> GetCustomerSummaryAsync(int customerId);
}
