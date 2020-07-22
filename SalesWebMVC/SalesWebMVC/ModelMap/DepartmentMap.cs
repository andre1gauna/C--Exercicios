using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMVC.Models;

namespace SalesWebMVC.ModelMap
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");

            builder.HasKey(t => t.Id);

            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasMany(x => x.Sellers)
                   .WithOne(x => x.Department)
                   .HasForeignKey(i => i.DepartmentId);
        }
    }
}
