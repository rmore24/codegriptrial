using System.Threading.Tasks;
using TrialTemplate.Configuration.Dto;

namespace TrialTemplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
