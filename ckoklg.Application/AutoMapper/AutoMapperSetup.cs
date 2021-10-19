using Ckoklg.Application.Services;
using Ckoklg.Application.ViewModels.Modules;
using Ckoklg.Application.ViewModels.Profiles;
using Ckoklg.Application.ViewModels.Users;
using Ckoklg.CrossCutting.Auth.ViewModels;
using Ckoklg.Domain.Entities;
using Profile = AutoMapper.Profile;
using ProfileUser = Ckoklg.Domain.Entities.Profile;

namespace Ckoklg.Application.AutoMapper
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
