namespace NLB.Server.Models.Database
{
    public class Customer
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }

        public Customer()
        {
            Transactions=new List<Transaction>();
        }
    }
}
