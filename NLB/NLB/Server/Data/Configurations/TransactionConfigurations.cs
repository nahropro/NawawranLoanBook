using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLB.Server.Models.Database;

namespace NLB.Server.Data.Configurations
{
    public class TransactionConfigurations : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> b)
        {
            b.Property(x=> x.Amount).HasPrecision(36, 18);

            b.Property(x=> x.DiscountAmount).HasPrecision(36, 18);

            b.Property(x => x.Note).IsRequired(false).HasMaxLength(2000).HasColumnType("nvarchar");

            b.HasIndex(x => x.MoneyInOrOut);

            b.Property(x => x.Date).HasColumnType("date");
            b.HasIndex(x => x.Date);

            b.HasOne(x => x.Customer)
                .WithMany(x=> x.Transactions)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
