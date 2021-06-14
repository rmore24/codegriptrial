using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TrialTemplate.Controllers
{
    public abstract class TrialTemplateControllerBase: AbpController
    {
        protected TrialTemplateControllerBase()
        {
            LocalizationSourceName = TrialTemplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
