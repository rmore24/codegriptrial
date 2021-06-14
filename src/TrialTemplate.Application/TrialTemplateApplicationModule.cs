using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrialTemplate.Authorization;

namespace TrialTemplate
{
    [DependsOn(
        typeof(TrialTemplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TrialTemplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TrialTemplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TrialTemplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
