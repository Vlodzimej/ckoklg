using Ckoklg.Data.Context;
using Ckoklg.Domain.Entities;
using Ckoklg.Domain.Interfaces;

namespace Ckoklg.Data.Repositories
{
    public class ProfileRepository: Repository<Profile>, IProfileRepository
	{
		public ProfileRepository(MySQLContext context)
			: base(context) { }

		public Profile GetDefault()
		{
			return Find(x => x.IsDefault);
		}
	}
}
