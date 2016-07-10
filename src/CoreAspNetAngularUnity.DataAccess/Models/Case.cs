using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAspNetAngularUnity.DataAccess.Models
{
    public class Case
    {
		[Key]
	    public int Id { get; set; }

	    public int OrganizationId { get; set; }
	    public Organization Organization { get; set; }
	    public string Name { get; set; }
	    public string Steps { get; set; }
	    public Importance Importance { get; set; }
    }

	public enum Importance
	{
		NotSet,
		Low,
		Medium,
		High,
		Required
	}
}
