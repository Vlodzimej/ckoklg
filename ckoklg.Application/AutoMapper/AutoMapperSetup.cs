using ckoklg.Application.Services;
using ckoklg.Application.ViewModels.Modules;
using ckoklg.Application.ViewModels.Profiles;
using ckoklg.Application.ViewModels.Users;
using ckoklg.CrossCutting.Auth.ViewModels;
using ckoklg.Domain.Entities;
using Profile = AutoMapper.Profile;
using ProfileUser = ckoklg.Domain.Entities.Profile;

namespace ckoklg.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            #region "ViewModel To Domain"

            CreateMap<UserRequestCreateAccountViewModel, User>()
                .ForMember(x => x.Password, y => y.MapFrom(m => UtilsService.EncryptPassword(m.Password)));

            #endregion

            #region "Domain to ViewModel"

            CreateMap<User, ContextUserViewModel>()
                .ForMember(x => x.Profile, m => m.MapFrom(map => map.ProfileId));
            CreateMap<User, UserViewModel>();
            CreateMap<User, UserResponseListViewModel>();
            CreateMap<User, UserResponseAuthenticateViewModel>()
                .ForMember(x => x.Profile, m => m.MapFrom(map => map.ProfileId));
            CreateMap<ProfileUser, ProfileViewModel>();
            CreateMap<Module, ModuleViewModel>();

            #endregion
        }
    }
}
