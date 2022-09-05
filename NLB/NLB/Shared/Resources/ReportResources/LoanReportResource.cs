using NLB.Shared.Resources.CustomerResources;
using NLB.Shared.Resources.QueryResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.ReportResources;

public class LoanReportResource
{
    public IEnumerable<SelectCustomerResource> Loans { get; set; }

    public decimal Balance => Loans?.Sum(x => x.Balance) ?? 0;

    public LoanQueryResource LoanQuery { get; set; }

    public LoanReportResource()
    {
        Loans=new List<SelectCustomerResource>();
    }
}
