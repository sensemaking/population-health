using System;
using System.Reflection;
using DbUp;

namespace Migrations
{
    class Program
    {
    
        static void Main(string[] args)
        {
            var connectionString = @"Server=(localdb)\PopulationHealth;Database=PopulationHealth;Integrated Security=True";

            DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                .WithExecutionTimeout(new TimeSpan(0, 0, 30, 0))
                .LogToConsole()
                .Build()
                .PerformUpgrade();
        }
    }
}
