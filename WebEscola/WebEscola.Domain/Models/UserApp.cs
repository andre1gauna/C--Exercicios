using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace Escola.Domain.Models
{
    public class UserApp : IdentityUser
    {       
        public string CPF { get; set; }
        public IEnumerable<Professor> Professor { get; set; }
        public IEnumerable<Aluno> Aluno { get; set; }
    }
}