using Escola.Domain.Models;
using WebEscola.Domain.Models;

namespace WebEscola.Domain.Interfaces
{
    public interface IAlunoRepository : IRepositoryBase<Aluno>
    {       
        Page<Aluno> GetPage(PageFilter pageFilter, string sortingProperty);
    }
}
