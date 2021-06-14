using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrialTemplate.Configuration;

namespace TrialTemplate.Web.Host.Startup
{
    [DependsOn(
       typeof(TrialTemplateWebCoreModule))]
    public class TrialTemplateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TrialTemplateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrialTemplateWebHostModule).GetAssembly());
        }
    }
}
