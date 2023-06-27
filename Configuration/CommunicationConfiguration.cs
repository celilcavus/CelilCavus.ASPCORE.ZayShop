using celilcavus.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace celilcavus.Configuration
{
    public class CommunicationConfiguration : IEntityTypeConfiguration<Communication>
    {
        public void Configure(EntityTypeBuilder<Communication> builder)
        {
            builder.HasIndex(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Mail).IsRequired();
            builder.Property(x=>x.Mail).HasMaxLength(100);
            
            builder.Property(x=>x.phoneNumber).IsRequired();
            builder.Property(x=>x.phoneNumber).HasMaxLength(15);
        }
    }
}