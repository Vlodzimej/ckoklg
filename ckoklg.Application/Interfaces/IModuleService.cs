using System.Collections.Generic;
using Ckoklg.Application.ViewModels.Modules;

namespace Ckoklg.Application.Interfaces
{
	public interface IModuleService
	{
		List<ModuleViewModel> GetByProfile(int profileId);
	}
}
