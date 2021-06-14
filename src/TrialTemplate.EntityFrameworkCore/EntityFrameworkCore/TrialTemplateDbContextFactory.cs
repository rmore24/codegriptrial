using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TrialTemplate.Configuration;
using TrialTemplate.Web;

namespace TrialTemplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TrialTemplateDbContextFactory : IDesignTimeDbContextFactory<TrialTemplateDbContext>
    {
        public TrialTemplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TrialTemplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TrialTemplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TrialTemplateConsts.ConnectionStringName));

            return new TrialTemplateDbContext(builder.Options);
        }
    }
}
