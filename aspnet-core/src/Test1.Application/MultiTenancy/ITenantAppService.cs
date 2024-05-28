using Abp.Application.Services;
using Test1.MultiTenancy.Dto;

namespace Test1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

