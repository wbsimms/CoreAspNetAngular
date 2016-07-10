using CoreAspNetAngular.DataAccess.Data;
using CoreAspNetAngular.DataAccess.Models;

namespace CoreAspNetAngular.DataAccess.Repositories
{
	public class OrganizationRepository<T> : RepositoryBase<T> where T : Entity
	{
		public OrganizationRepository(ApplicationDbContext dataAccessContext) : base(dataAccessContext)
		{
		}
	}
}