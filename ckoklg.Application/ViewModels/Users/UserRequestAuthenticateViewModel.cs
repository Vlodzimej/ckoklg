﻿using System.ComponentModel.DataAnnotations;

namespace Ckoklg.Application.ViewModels.Users
{
    public class UserRequestAuthenticateViewModel
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
