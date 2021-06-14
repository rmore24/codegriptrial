using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrialTemplate.EntityFrameworkCore;
using TrialTemplate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TrialTemplate.Web.Tests
{
    [DependsOn(
        typeof(TrialTemplateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TrialTemplateWebTestModule : AbpModule
    {
        public TrialTemplateWebTestModule(TrialTemplateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrialTemplateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TrialTemplateWebMvcModule).Assembly);
        }
    }
}