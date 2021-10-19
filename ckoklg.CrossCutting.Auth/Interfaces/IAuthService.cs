using System.Security.Claims;
using Ckoklg.CrossCutting.Auth.ViewModels;

namespace Ckoklg.CrossCutting.Auth.Interfaces
{
    public interface IAuthService
    {
        ContextUserViewModel GetLoggedUser();
        ClaimsIdentity GetClaimsIdentityByContextUser(ContextUserViewModel user, string authenticationType = "Bearer");
    }
}
