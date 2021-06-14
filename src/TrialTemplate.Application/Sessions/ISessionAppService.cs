using System.Threading.Tasks;
using Abp.Application.Services;
using TrialTemplate.Sessions.Dto;

namespace TrialTemplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
