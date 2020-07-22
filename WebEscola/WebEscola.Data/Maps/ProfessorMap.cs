using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Data.Maps
{
    class ProfessorMap : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable(nameof(Professor));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CodigoFuncionario)
               .HasMaxLength(20)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Professor)
                .HasForeignKey(k => k.UserId);
            
        }

    }
}
