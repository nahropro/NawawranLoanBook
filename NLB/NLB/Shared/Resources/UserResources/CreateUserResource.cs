using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLB.Shared.Resources.UserResources;

public class CreateUserResource
{
    [Required(ErrorMessage ="پێویستە پڕبكرێتەوە")]
    [StringLength(50,ErrorMessage ="نابێت لە {1} وشە زیاتربێت")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "پێویستە پڕبكرێتەوە")]
    [StringLength(50, ErrorMessage = "نابێت لە {1} وشە زیاتربێت")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "پێویستە پڕبكرێتەوە")]
    [StringLength(50, ErrorMessage = "نابێت لە {1} وشە زیاتربێت")]
    [Compare(nameof(Password), ErrorMessage ="دوبارەی وشەی نهێنی جیاوازە لە وشەی نهێنی")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}
