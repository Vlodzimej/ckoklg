using System.Collections.Generic;
using System.Linq;
using Ckoklg.Domain.Entities;

namespace Ckoklg.Domain.Interfaces
{
    public interface IModuleRepository
	{
		IQueryable<Module> GetByProfileId(int profileId);
	}
}
