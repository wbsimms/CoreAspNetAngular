using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreAspNetAngular.Controllers
{
	[Authorize]
    public class TestMonkeyController : Controller
    {
        public IActionResult Index()
        {
	        return View();
        }
    }
}