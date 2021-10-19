﻿using System.Collections.Generic;
using Ckoklg.Application.ViewModels.Users;

namespace Ckoklg.Application.Interfaces
{
	public interface IUserService
	{
        bool Post(UserRequestCreateAccountViewModel user, string host);
        UserResponseAuthenticateViewModel Authenticate(UserRequestAuthenticateViewModel user);
        bool ForgotPassword(string email);
        bool ChangePassword(UserRequestChangePasswordViewModel user);
        bool ActivateUser(int userId);
        bool DeactivateUser(int userId);
        UserViewModel GetById(int userId);
        void ActivateByEmail(string email, string code);
        List<UserViewModel> Get();
        bool Put(UserUpdateAccount user);
    }
}
