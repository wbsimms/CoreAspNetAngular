﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAspNetAngular.DataAccess.Models
{
    public class Organization : Entity
    {
		[Key]
	    public int Id { get; set; }
	    public string Name { get; set; }
    }
}
