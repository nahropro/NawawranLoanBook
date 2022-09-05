using System.ComponentModel.DataAnnotations;

namespace NLB.Shared.Resources.TransactionResources;

public class UpdateTransactionResource
{
    /// <summary>
    /// Only positive number
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "دەبێت ژمارەكە موجەب بێت")]
    public decimal Amount { get; set; }

    /// <summary>
    /// Only positive number
    /// </summary>
    [Range(0, double.MaxValue, ErrorMessage = "دەبێت ژمارەكە موجەب بێت")]
    public decimal DiscountAmount { get; set; }

    [StringLength(2000, ErrorMessage ="نابێت لە {1} پیت زیاتربێت")]
    public string? Note { get; set; }

    /// <summary>
    /// False for money-in (customer purchase), True for money-out(customer withdraw)
    /// </summary>
    public bool MoneyInOrOut { get; set; }

    [Required(ErrorMessage ="پێویستە پڕبكرێتەوە")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "پێویستە پڕبكرێتەوە")]
    public int CustomerId { get; set; }
}
