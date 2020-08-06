using Microsoft.Extensions.Hosting;
using HostBuilder = Sensemaking.Web.Host.HostBuilder;

namespace Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostBuilder.Create<Startup>(args).Build().Run();
        }
    }
}
