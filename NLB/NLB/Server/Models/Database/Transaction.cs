namespace NLB.Server.Models.Database;

public class Transaction
{
    public int Id { get; set; }

    /// <summary>
    /// Only positive number
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Only positive number
    /// </summary>
    public decimal DiscountAmount { get; set; }

    public string Note { get; set; }
    
    /// <summary>
    /// False for money-in (customer purchase), True for money-out(customer withdraw)
    /// </summary>
    public bool MoneyInOrOut { get; set; }

    public DateTime Date { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }
}
