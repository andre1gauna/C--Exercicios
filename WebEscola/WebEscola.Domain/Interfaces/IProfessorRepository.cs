using Escola.Domain.Models;
using WebEscola.Domain.Models;

namespace WebEscola.Domain.Interfaces
{
    public interface IProfessorRepository : IRepositoryBase<Professor>
    {        
        Page<Professor> GetPage(PageFilter pageFilter, string sortingProperty);
    }
}
