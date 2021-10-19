using Microsoft.Extensions.DependencyInjection;
using System;
using Ckoklg.Application.Interfaces;
using Ckoklg.Application.Services;
using Ckoklg.CrossCutting.Auth.Interfaces;
using Ckoklg.CrossCutting.Auth.Services;
using Ckoklg.CrossCutting.Notification.Interfaces;
using Ckoklg.CrossCutting.Notification.Services;
using Ckoklg.Data.Repositories;
using Ckoklg.Domain.Interfaces;

namespace Ckoklg.CrossCutting.IoC
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
