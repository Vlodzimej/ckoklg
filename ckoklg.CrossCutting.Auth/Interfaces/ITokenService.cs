using Ckoklg.CrossCutting.Auth.ViewModels;

namespace Ckoklg.CrossCutting.Auth.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(ContextUserViewModel usuario);
    }
}
