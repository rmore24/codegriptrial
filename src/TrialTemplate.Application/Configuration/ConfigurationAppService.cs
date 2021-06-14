using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TrialTemplate.Configuration.Dto;

namespace TrialTemplate.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TrialTemplateAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
