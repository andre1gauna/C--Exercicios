using System.Collections;
using System.Collections.Generic;

namespace Escola.Domain.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string CodigoFuncionario { get; set; }

        public UserApp User { get; set; }
        public string UserId { get; set; }

        public IEnumerable<Grade> Grades { get; set; }
    }
}
