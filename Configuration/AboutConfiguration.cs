using celilcavus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace celilcavus.Configuration
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
           builder.HasIndex(x=>x.Id);
           builder.Property(x=>x.Id).UseIdentityColumn();

           builder.Property(x=>x.Title).HasMaxLength(100);
           builder.Property(x=>x.Title).IsRequired();

           builder.Property(x=>x.Description).HasMaxLength(750);
           builder.Property(x=>x.Description).IsRequired();
        }
    }
}