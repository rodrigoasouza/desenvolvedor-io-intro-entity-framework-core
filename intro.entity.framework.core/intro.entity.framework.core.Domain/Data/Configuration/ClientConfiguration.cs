using Intro.Entity.Framework.Core.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intro.Entity.Framework.Core.Domain.Data.Configuration
{
    internal class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            _ = builder.ToTable(nameof(Client), DataConst.Schema);
            _ = builder.HasKey(x => x.Id);

            _ = builder.Property(x => x.Name).HasColumnType("VARCHAR(80)").IsRequired();
            _ = builder.Property(x => x.Phone).HasColumnType("CHAR(11)");
            _ = builder.Property(x => x.ZipCode).HasColumnType("CHAR(8)").IsRequired();
            _ = builder.Property(x => x.State).HasColumnType("CHAR(2)").IsRequired();
            _ = builder.Property(X => X.City).HasColumnType("VARCHAR(60)").IsRequired();

            _ = builder.HasIndex(x => x.Phone).HasName("idx_client_phone");
        }
    }
}
