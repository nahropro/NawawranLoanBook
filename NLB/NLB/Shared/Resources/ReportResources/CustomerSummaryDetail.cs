using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.ReportResources
{
    public class CustomerSummaryDetail
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public decimal DiscountAmount { get; set; }

        public string Note { get; set; }

        /// <summary>
        /// False for money-in (customer purchase), True for money-out(customer withdraw)
        /// </summary>
        public bool MoneyInOrOut { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreationDateTime { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public decimal BalanceInTime { get; set; }
    }
}
