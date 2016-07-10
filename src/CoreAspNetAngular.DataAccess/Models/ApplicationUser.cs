using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoreAspNetAngular.DataAccess.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
	    public string FirstName { get; set; }
	    public string LastName { get; set; }
	    public Organization Organization { get; set; }
		public int OrganizationId { get; set; }
	}
}
