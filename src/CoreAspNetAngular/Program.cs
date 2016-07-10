using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace CoreAspNetAngular
{
    public class Program
    {
	    //static ILogger log = ApplicationLogging.CreateLogger<Program>();

        public static void Main(string[] args)
        {
			//log.LogInformation("Program Started");

			var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
