using System.Collections.Generic;
using System.Linq;
using ckoklg.Data.Context;
using ckoklg.Domain.Entities;
using ckoklg.Domain.Interfaces;

namespace ckoklg.Data.Repositories
{
    public class ModuleRepository: Repository<Module>, IModuleRepository
	{
        public ModuleRepository(MySQLContext context)
            : base(context) { }

        public IQueryable<Module> GetByProfileId(int profileId)
        {
            return (from m in context.Modules
                    join mp in context.ModuleProfiles on m.Id equals mp.ModuleId
                    where mp.ProfileId == profileId
                    select m);
        }
    }
}
