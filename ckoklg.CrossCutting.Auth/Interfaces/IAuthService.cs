using System.Security.Claims;
using ckoklg.CrossCutting.Auth.ViewModels;

namespace ckoklg.CrossCutting.Auth.Interfaces
{
    public interface IAuthService
    {
        ContextUserViewModel GetLoggedUser();
        ClaimsIdentity GetClaimsIdentityByContextUser(ContextUserViewModel user, string authenticationType = "Bearer");
    }
}
