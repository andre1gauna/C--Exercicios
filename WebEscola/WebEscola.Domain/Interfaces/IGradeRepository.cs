using Escola.Domain.Models;
using WebEscola.Domain.Models;

namespace WebEscola.Domain.Interfaces
{
    public interface IGradeRepository : IRepositoryBase<Grade>
    {       
        Page<Grade> GetPage(PageFilter pageFilter, string sortingProperty);
    }
}
