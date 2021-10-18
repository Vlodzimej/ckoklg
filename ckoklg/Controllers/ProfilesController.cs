using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ckoklg.Application.Interfaces;
using ckoklg.CrossCutting.Auth.Interfaces;
using ckoklg.CrossCutting.Auth.ViewModels;

namespace ckoklg.Controllers
{
	[Route("api/[controller]"), ApiController]
	public class ProfilesController : ControllerBase
	{
        private readonly IProfileService service;
        private readonly IAuthService authService;

        public ProfilesController(IProfileService service, IAuthService authService)
        {
            this.service = service;
            this.authService = authService;
        }

    }
}
