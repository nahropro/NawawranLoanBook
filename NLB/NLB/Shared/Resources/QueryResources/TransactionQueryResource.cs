using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.QueryResources
{
    public class TransactionQueryResource
    {
        public int? Id { get; set; }

        public int? CustomerId { get; set; }

        /// <summary>
        /// False for money-in (customer purchase),
        /// True for money-out(customer withdraw),
        /// Null for both
        /// </summary>
        public bool? MoneyInOrOut { get; set; }

        private DateTime? startDate;

        [DataType(DataType.Date)]
        public DateTime? StartDate
        {
            get { return startDate?.Date; }
            set { startDate = value?.Date; }
        }

        private DateTime? endDate;

        [DataType(DataType.Date)]
        public DateTime? EndDate
        {
            get { return endDate?.Date; }
            set { endDate = value?.Date; }
        }
    }
}
