using Abp.Application.Services;
using TrialTemplate.MultiTenancy.Dto;

namespace TrialTemplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

