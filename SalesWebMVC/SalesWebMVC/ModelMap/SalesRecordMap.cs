using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SalesWebMVC.Models.Enums
{
    public class SalesRecordMap : IEntityTypeConfiguration<SalesRecord>
    {
        public void Configure(EntityTypeBuilder<SalesRecord> builder)
        {
            builder.ToTable("SalesRecord");

            builder.HasKey(t => t.Id);

            builder.Property(x => x.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            builder.Property(x => x.Status)
                .HasColumnType("int")
                .IsRequired();
            builder.Property(x => x.Date)
                .HasColumnType("datetime2")
                .IsRequired();

        }
    }
}
