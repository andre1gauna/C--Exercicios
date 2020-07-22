using Escola.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Data.Maps
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable(nameof(Aluno));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.RA)
               .HasMaxLength(20)
               .HasColumnType("varchar(10)")
               .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Aluno)
                .HasForeignKey(k => k.UserId);
        }
    }
}
