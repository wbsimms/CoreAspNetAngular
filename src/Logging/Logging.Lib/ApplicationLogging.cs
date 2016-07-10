using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Logging.Lib
{
    public static class ApplicationLogging
    {
	    public static ILoggerFactory LoggerFactory { get; } = new LoggerFactory().AddConsole().AddDebug();
		public static ILogger CreateLogger<T>()
		{
			return LoggerFactory.CreateLogger<T>();
		}
    }
}
