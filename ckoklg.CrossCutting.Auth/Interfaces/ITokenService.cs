using ckoklg.CrossCutting.Auth.ViewModels;

namespace ckoklg.CrossCutting.Auth.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(ContextUserViewModel usuario);
    }
}
