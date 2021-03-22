using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MrPizza.Logging
{
    static public class Logger
    {
        public static readonly ILogger _performanceLogger;
        public static readonly ILogger _usageLogger;
        public static readonly ILogger _errorLogger;
        public static readonly ILogger _diagnosticLogger;

        static Logger()
        {
            _performanceLogger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            _usageLogger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            _errorLogger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            _diagnosticLogger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Seq("http://localhost:5341")
                .WriteTo.Console()
                .CreateLogger();

            // ********** Could instead save the new LoggerConfiguration setup to a variable performanceLogger.
            // ********** Then save the variable to the Log.Logger property.
            // ********** We can then access the Log.Logger property from anywhere.
            Log.Logger = _diagnosticLogger;
        }
    }
}
