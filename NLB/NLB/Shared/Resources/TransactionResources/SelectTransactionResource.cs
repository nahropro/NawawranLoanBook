using NLB.Shared.Resources.CustomerResources;

namespace NLB.Shared.Resources.TransactionResources;

public class SelectTransactionResource
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

    public SelectCustomerResource Customer { get; set; }
}
