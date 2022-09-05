using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.CustomerResources
{
    public class UpdateCustomerResource
    {
        [Required(ErrorMessage ="پێویستە پڕبكرێتەوە")]
        [StringLength(255, ErrorMessage ="نابێت لە {1} پیت زیاتربێت")]
        public string FullName { get; set; }

        [StringLength(500, ErrorMessage = "نابێت لە {1} پیت زیاتربێت")]
        public string? Address { get; set; }

        [StringLength(50, ErrorMessage = "نابێت لە {1} پیت زیاتربێت")]
        public string? Phone { get; set; }
    }
}
