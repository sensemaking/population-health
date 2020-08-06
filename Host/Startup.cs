using Sensemaking.Web.Host;
using Serilog;

namespace Host
{
    public class Startup : ApiStartup
    {
        protected override ILogger Logger { get; } = new LoggerConfiguration().CreateLogger();
    }
}