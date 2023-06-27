using celilcavus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace celilcavus.Configuration
{
    public class ServicesConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
           builder.HasKey(x=>x.Id);
           builder.Property(x=>x.Id).UseIdentityColumn();

           builder.Property(x=>x.Icon).IsRequired();
           builder.Property(x=>x.Icon).HasMaxLength(100);

           builder.Property(x=>x.ShortDescription).IsRequired();
           builder.Property(x=>x.ShortDescription).HasMaxLength(300);
        }
    }
}