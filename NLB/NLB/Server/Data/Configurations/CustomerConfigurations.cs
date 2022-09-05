using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLB.Server.Models.Database;

namespace NLB.Server.Data.Configurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> b)
        {
            b.Property(x => x.FullName).IsRequired().HasMaxLength(255).HasColumnType("nvarchar");
            b.HasIndex(x => x.FullName).IsUnique();

            b.Property(x=> x.Address).IsRequired(false).HasMaxLength(500).HasColumnType("nvarchar");

            b.Property(x=> x.Phone).IsRequired(false).HasMaxLength(50).HasColumnType("nvarchar");
        }
    }
}
