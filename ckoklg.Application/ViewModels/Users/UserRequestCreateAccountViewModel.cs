﻿using System.ComponentModel.DataAnnotations;

namespace Ckoklg.Application.ViewModels.Users
{
    public class UserRequestCreateAccountViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirm { get; set; }
    }
}
