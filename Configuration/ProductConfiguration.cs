using celilcavus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace celilcavus.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.Image).HasMaxLength(100);

            builder.Property(x => x.Image1).IsRequired();
            builder.Property(x => x.Image1).HasMaxLength(100);

            builder.Property(x => x.Image2).IsRequired();
            builder.Property(x => x.Image2).HasMaxLength(100);

            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Name).HasMaxLength(50);

            builder.Property(x=>x.Price).IsRequired();
            builder.Property(x=>x.Price).HasColumnType("decimal(10,2)");

            builder.Property(x=>x.Point).IsRequired();
        

            builder.Property(x=>x.BrandId).IsRequired();
           

            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(50);

            builder.Property(x=>x.ColorId).IsRequired();
        }
    }
}