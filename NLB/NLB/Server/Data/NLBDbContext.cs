using Microsoft.EntityFrameworkCore;
using NLB.Server.Data.Configurations;
using NLB.Server.Models.Database;

namespace NLB.Server.Data
{
    public class NLBDbContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        public NLBDbContext(DbContextOptions<NLBDbContext> options): base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new TransactionConfigurations());
            modelBuilder.ApplyConfiguration(new UserConfigurations());
        }
    }
}
