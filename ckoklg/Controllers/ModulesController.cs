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
	public class ModulesController : ControllerBase
	{
        private readonly IModuleService service;
        private readonly IAuthService authService;

        public ModulesController(IModuleService service, IAuthService authService)
        {
            this.service = service;
            this.authService = authService;
        }

        [HttpGet]
        public IActionResult GetUserLogged()
        {
            try
            {
                ContextUserViewModel _user = authService.GetLoggedUser();
                if (_user == null)
                    return Unauthorized();

                return Ok(service.GetByProfile(int.Parse(_user.Profile)));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
