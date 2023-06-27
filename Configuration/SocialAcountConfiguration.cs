using celilcavus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace celilcavus.Configuration
{
    public class SocialAcountConfiguration : IEntityTypeConfiguration<SocialAcounts>
    {
        public void Configure(EntityTypeBuilder<SocialAcounts> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Facebook).IsRequired();
            builder.Property(x=>x.Facebook).HasMaxLength(100);

             builder.Property(x=>x.Instagram).IsRequired();
            builder.Property(x=>x.Instagram).HasMaxLength(100);

             builder.Property(x=>x.Twitter).IsRequired();
            builder.Property(x=>x.Twitter).HasMaxLength(100);

             builder.Property(x=>x.Linkedin).IsRequired();
            builder.Property(x=>x.Linkedin).HasMaxLength(100);
        }
    }
}