using Intro.Entity.Framework.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro.Entity.Framework.Core.Domain.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            _ = builder.ToTable(nameof(Product), DataConst.Schema);
            _ = builder.HasKey(x => x.Id);

            //  Let's use another table configuration template to save the example
            _ = builder.Property(x => x.Barcode).HasMaxLength(14).IsRequired();
            _ = builder.Property(x => x.Description).HasMaxLength(60);
            _ = builder.Property(x => x.Price).IsRequired();
            _ = builder.Property(x => x.Type).HasConversion<int>();
        }
    }
}
