using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using KuntoLps2.Configuration;
using KuntoLps2.Web;

namespace KuntoLps2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KuntoLps2DbContextFactory : IDesignTimeDbContextFactory<KuntoLps2DbContext>
    {
        public KuntoLps2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KuntoLps2DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KuntoLps2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(KuntoLps2Consts.ConnectionStringName));

            return new KuntoLps2DbContext(builder.Options);
        }
    }
}
