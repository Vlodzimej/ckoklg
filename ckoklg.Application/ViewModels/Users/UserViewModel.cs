using Ckoklg.Application.ViewModels.Profiles;

namespace Ckoklg.Application.ViewModels.Users
{
    public class UserViewModel: EntityViewModel
	{
        public string Name { get; set; }
        public string Email { get; set; }
        public ProfileViewModel? Profile { get; set; }
    }
}
