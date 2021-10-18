using System.Collections.Generic;
using ckoklg.Application.ViewModels.Modules;

namespace ckoklg.Application.Interfaces
{
	public interface IModuleService
	{
		List<ModuleViewModel> GetByProfile(int profileId);
	}
}
