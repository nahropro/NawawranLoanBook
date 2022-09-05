using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.QueryResources
{
    public class LoanQueryResource
    {
        public decimal? BalanceStart { get; set; }

        public decimal? BalanceEnd { get; set; }

        /// <summary>
        /// False for creditor, True for debter, Null for both
        /// </summary>
        public bool? CreditorOrDebter { get; set; }
    }
}
