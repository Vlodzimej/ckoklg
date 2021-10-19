using Ckoklg.Application.ViewModels.Profiles;

namespace Ckoklg.Application.ViewModels.Users
{
    public class UserResponseListViewModel : EntityViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAuthorised { get; set; }
        public ProfileViewModel Profile { get; set; }
    }
}
