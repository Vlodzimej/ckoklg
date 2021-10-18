using System.Collections.Generic;
using System.Linq;
using ckoklg.Domain.Entities;

namespace ckoklg.Domain.Interfaces
{
    public interface IModuleRepository
	{
		IQueryable<Module> GetByProfileId(int profileId);
	}
}
