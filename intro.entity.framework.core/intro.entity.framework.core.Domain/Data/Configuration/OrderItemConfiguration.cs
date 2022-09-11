using Intro.Entity.Framework.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro.Entity.Framework.Core.Domain.Data.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            _ = builder.ToTable(nameof(OrderItem), DataConst.Schema);
            _ = builder.HasKey(x => x.Id);

            _ = builder.Property(x => x.Quantity).HasDefaultValue(0).IsRequired();
            _ = builder.Property(x => x.Price).IsRequired();
            _ = builder.Property(x => x.Discount).IsRequired();
        }
    }
}
