using System.Linq;
using ckoklg.Domain.Entities;

namespace ckoklg.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
	{
		User GetByEmailAndPassword(string email, string password);
		User GetByEmail(string email);
		User GetByEmailAndCode(string email, string code);
		IQueryable<User> GetByProfileId(int profileId);
		User GetById(int userId);
		IQueryable<User> Get();
	}
}
