using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.UserResources;

public class TokenResource
{
    public string Token { get; set; }

    public DateTime ExpireDate { get; set; }

    public string UserName { get; set; }

    public int UserId { get; set; }
}
