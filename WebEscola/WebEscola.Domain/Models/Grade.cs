using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }
        public string NomeDisciplina { get; set; }
        public string NomeTurma { get; set; }

        public Professor Professor { get; set; }
        public int ProfessorId { get; set; }

        public IEnumerable<GradeAluno> GradeAlunos { get; set; }
    }
}
