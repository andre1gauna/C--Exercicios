using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Domain.Models
{
    public class GradeAluno
    {
        public int Id { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
