using System.Threading.Tasks;
using Abp.Application.Services;
using TrialTemplate.Authorization.Accounts.Dto;

namespace TrialTemplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
