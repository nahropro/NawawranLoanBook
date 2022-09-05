using NLB.Shared.Resources.CustomerResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.ReportResources;

public class CustomerSummaryReportResource
{
    public SelectCustomerResource Customer { get; set; }

    public IEnumerable<CustomerSummaryDetail> CustomerSummaryDetails { get; set; }

    public CustomerSummaryReportResource()
    {
        CustomerSummaryDetails=new List<CustomerSummaryDetail>();
    }
}
