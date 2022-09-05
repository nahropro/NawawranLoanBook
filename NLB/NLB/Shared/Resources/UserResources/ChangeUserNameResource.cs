using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.UserResources;

public class ChangeUserNameResource
{
    private string userName;
    /// <summary>
    /// Spaces from start and end is going to be removed,
    /// and empty string is goning to be rejected
    /// </summary>
    [Required(AllowEmptyStrings = false, ErrorMessage = "پێویستە پڕبكرێتەوە")]
    [MaxLength(50, ErrorMessage = "نابێت لە {1} وشە زیاتربێت")]
    public string UserName
    {
        get { return userName; }
        set { userName = value.Trim(); }
    }

    [Required(ErrorMessage = "پێویستە پڕبكرێتەوە")]
    [StringLength(50, ErrorMessage = "نابێت لە {1} وشە زیاتربێت")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
