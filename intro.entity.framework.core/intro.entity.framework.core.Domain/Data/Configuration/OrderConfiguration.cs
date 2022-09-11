using Intro.Entity.Framework.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro.Entity.Framework.Core.Domain.Data.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            _ = builder.ToTable(nameof(Order), DataConst.Schema);
            _ = builder.HasKey(x => x.Id);

            _ = builder.Property(x => x.Start).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            _ = builder.Property(x => x.Status).HasConversion<string>();
            _ = builder.Property(x => x.Shipping).HasConversion<int>();
            _ = builder.Property(x => x.Note).HasColumnType("VARCHAR(512)");

            _ = builder.HasMany(x => x.Itens).WithOne(x => x.Order).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
