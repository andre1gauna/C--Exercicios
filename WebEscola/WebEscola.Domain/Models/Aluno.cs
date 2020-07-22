using System.Collections.Generic;

namespace Escola.Domain.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string RA { get; set; }

        public UserApp User { get; set; }
        public string UserId { get; set; }

        public IEnumerable<GradeAluno> GradeAlunos { get; set; }
    }
}
