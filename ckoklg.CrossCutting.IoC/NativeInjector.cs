using Microsoft.Extensions.DependencyInjection;
using System;
using ckoklg.Application.Interfaces;
using ckoklg.Application.Services;
using ckoklg.CrossCutting.Auth.Interfaces;
using ckoklg.CrossCutting.Auth.Services;
using ckoklg.CrossCutting.Notification.Interfaces;
using ckoklg.CrossCutting.Notification.Services;
using ckoklg.Data.Repositories;
using ckoklg.Domain.Interfaces;

namespace ckoklg.CrossCutting.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();

            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IModuleService, ModuleService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();

            #endregion
        }
    }
}
