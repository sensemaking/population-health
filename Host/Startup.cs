using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sensemaking.Dapper;
using Sensemaking.Query.Dapper;
using Sensemaking.Web.Host;
using Serilog;

namespace Host
{
    public class Startup : ApiStartup
    {
        protected override ILogger Logger { get; } = new LoggerConfiguration().CreateLogger();

        public override void ConfigureServices(IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("localsettings.json", true, true)
                .Build();

            base.ConfigureServices(services);
            services.AddSingleton<IDb>(p => new Db(config["ConnectionString"]));
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            base.Configure(app, env);
            Query.Configure(app.ApplicationServices.GetRequiredService<IDb>());
        }
    }
}