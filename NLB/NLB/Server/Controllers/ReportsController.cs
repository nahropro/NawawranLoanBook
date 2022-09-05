using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLB.Server.Repos;
using NLB.Shared.Resources.QueryResources;
using NLB.Shared.Resources.ReportResources;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NLB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportsController : ControllerBase
    {
        private readonly ICustomerRepo customerRepo;

        public ReportsController(ICustomerRepo customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        // GET: api/<ReportsController>
        [HttpGet("Loan")]
        public async Task<LoanReportResource> Loan([FromQuery] LoanQueryResource query)
        {
            return await customerRepo.GetLoanReportAsync(query);
        }

        [HttpGet("CustomerSummary/{customerId:int}")]
        public async Task<CustomerSummaryReportResource> CustomerSummary(int customerId)
        {
            return await customerRepo.GetCustomerSummaryReportAsync(customerId);
        }
    }
}
