using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAspNetAngular.DataAccess.Data;
using CoreAspNetAngular.DataAccess.Models;

namespace CoreAspNetAngular.DataAccess.Repositories
{
    public class CaseRepository<T> : RepositoryBase<T> where T: Entity
    {
	    public CaseRepository(ApplicationDbContext dataAccessContext) : base(dataAccessContext)
	    {
	    }
    }
}
