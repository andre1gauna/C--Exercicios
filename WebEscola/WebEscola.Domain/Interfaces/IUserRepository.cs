using Escola.Domain.Models;
using Microsoft.AspNetCore.Identity;
using WebEscola.Domain.Models;

namespace WebEscola.Domain.Interfaces
{
    public interface IUserRepository : IRepositoryBase<UserApp>
    {
        UserApp FindByEmail(string email);
        Page<IdentityUser> GetPage(PageFilter pageFilter, string sortingProperty);
    }
}
