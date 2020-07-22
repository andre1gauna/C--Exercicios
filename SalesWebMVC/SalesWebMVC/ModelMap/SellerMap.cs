using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMVC.Models;

namespace SalesWebMVC.ModelMap
{
    public class SellerMap : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.ToTable("Seller");

            builder.HasKey(t => t.Id);

            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder.Property(x => x.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();
            builder.Property(x => x.BaseSalary)
               .HasColumnType("decimal(18,2)")
               .IsRequired();
            builder.Property(x => x.BirthDate)
               .HasColumnType("datetime2")
               .IsRequired();

            builder.HasMany(x => x.SalesRecord)
                   .WithOne(x => x.Seller)
                   .HasForeignKey(i => i.SellerId);
        }
    }
}
