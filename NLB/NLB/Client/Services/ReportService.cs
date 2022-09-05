using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.ReportResources;

namespace NLB.Client.Services;

public class ReportService : IReportService
{
    private readonly IHttpService httpService;

    public ReportService(IHttpService httpService)
    {
        this.httpService = httpService;
    }

    public async Task<LoanReportResource> GetLoanAsync(LoanQueryResource query = null)
    {
        return await httpService.GetAsync<LoanReportResource>("api/reports/loan", query);
    }

    public async Task<CustomerSummaryReportResource> GetCustomerSummaryAsync(int customerId)
    {
        return await httpService.GetAsync<CustomerSummaryReportResource>($"api/reports/customersummary/{customerId}");
    }
}
