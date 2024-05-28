using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Test1.Configuration;
using Test1.Web;

namespace Test1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Test1DbContextFactory : IDesignTimeDbContextFactory<Test1DbContext>
    {
        public Test1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Test1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Test1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Test1Consts.ConnectionStringName));

            return new Test1DbContext(builder.Options);
        }
    }
}
