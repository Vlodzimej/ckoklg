﻿using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using Ckoklg.Application.Interfaces;
using Ckoklg.Application.ViewModels.Modules;
using Ckoklg.Domain.Entities;
using Ckoklg.Domain.Interfaces;

namespace Ckoklg.Application.Services
{
	public class ModuleService: IModuleService
	{
		private readonly IMapper mapper;
		private readonly IModuleRepository repository;

		public ModuleService(IModuleRepository repository, IMapper mapper)
		{
			this.repository = repository;
			this.mapper = mapper;
		}

		public List<ModuleViewModel> GetByProfile(int profileId)
		{
			IQueryable<Module> _modules = repository.GetByProfileId(profileId);

			return mapper.Map<List<ModuleViewModel>>(_modules);
		}
	}
}
