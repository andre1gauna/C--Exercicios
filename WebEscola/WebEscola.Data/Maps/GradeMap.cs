using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Escola.Data.Maps
{
    public class GradeMap : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(k => k.Id);

            builder.ToTable(nameof(Grade));

            builder.Property(x => x.NomeCurso)
               .HasMaxLength(20)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.Property(x => x.NomeDisciplina)
               .HasMaxLength(20)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.Property(x => x.NomeTurma)
               .HasMaxLength(20)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.HasOne(x => x.Professor)
                .WithMany(x => x.Grades)
                .HasForeignKey(k => k.ProfessorId);

        }
    }
}
