using Escola.Data.Maps;
using Escola.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Escola.Data.Context
{
    public class EscolaContexto : IdentityDbContext<UserApp>
    {
        public EscolaContexto(DbContextOptions<EscolaContexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<GradeAluno> GradeAlunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new GradeAlunoMap());
            modelBuilder.ApplyConfiguration(new GradeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}