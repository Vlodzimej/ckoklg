using ckoklg.Data.Context;
using ckoklg.Domain.Entities;
using ckoklg.Domain.Interfaces;

namespace ckoklg.Data.Repositories
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
