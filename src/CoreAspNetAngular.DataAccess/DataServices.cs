using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CoreAspNetAngular.DataAccess
{
    public class DataServices
    {
		IServiceCollection coll = new ServiceCollection();

		public DataServices()
	    {
	    }

	    public void Load(IServiceCollection coll)
	    {
//		    coll.AddTransient<>()
	    }
    }
}
