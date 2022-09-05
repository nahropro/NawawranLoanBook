using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLB.Server.Models.Database;

namespace NLB.Server.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> b)
        {
            b.Property(x => x.UserName).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
            b.HasIndex(x => x.UserName).IsUnique();

            b.Property(x => x.PasswordHash).IsRequired().HasMaxLength(1000).HasColumnType("nvarchar");

            b.Property(x => x.Salt).IsRequired().HasMaxLength(1000).HasColumnType("nvarchar");
        }
    }
}
