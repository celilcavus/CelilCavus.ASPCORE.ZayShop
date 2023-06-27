using celilcavus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace celilcavus.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brands>
    {
        public void Configure(EntityTypeBuilder<Brands> builder)
        {
            builder.HasIndex(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Icon).IsRequired();
            builder.Property(x=>x.Icon).HasMaxLength(100);

            builder.Property(x=>x.ShortDescription).IsRequired();
            builder.Property(x=>x.ShortDescription).HasMaxLength(300);
        }
    }
}