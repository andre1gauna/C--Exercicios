using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Data.Maps
{
    public class GradeAlunoMap : IEntityTypeConfiguration<GradeAluno>
    {
        public void Configure(EntityTypeBuilder<GradeAluno> builder)
        {
            builder.ToTable(nameof(GradeAluno));

            builder.HasKey(x => new { x.AlunoId, x.GradeId });

            builder.HasOne(x => x.Aluno)
                .WithMany(x => x.GradeAlunos)
                .HasForeignKey(k => k.AlunoId);

            builder.HasOne(x => x.Grade)
                .WithMany(x => x.GradeAlunos)
                .HasForeignKey(k => k.GradeId);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
